using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Math;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000035 RID: 53
	public class DSAManaged : DSA
	{
		// Token: 0x060002FA RID: 762 RVA: 0x00031310 File Offset: 0x0002F510
		// Note: this type is marked as 'beforefieldinit'.
		static DSAManaged()
		{
			Il2CppClassPointerStore<DSAManaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "DSAManaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr);
			DSAManaged.NativeFieldInfoPtr_keypairGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "keypairGenerated");
			DSAManaged.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "m_disposed");
			DSAManaged.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "p");
			DSAManaged.NativeFieldInfoPtr_q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "q");
			DSAManaged.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "g");
			DSAManaged.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "x");
			DSAManaged.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "y");
			DSAManaged.NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "j");
			DSAManaged.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "seed");
			DSAManaged.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "counter");
			DSAManaged.NativeFieldInfoPtr_j_missing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "j_missing");
			DSAManaged.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "rng");
			DSAManaged.NativeFieldInfoPtr_KeyGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "KeyGenerated");
			DSAManaged.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663722);
			DSAManaged.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663723);
			DSAManaged.NativeMethodInfoPtr_Generate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663724);
			DSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663725);
			DSAManaged.NativeMethodInfoPtr_add_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663726);
			DSAManaged.NativeMethodInfoPtr_GenerateParams_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663727);
			DSAManaged.NativeMethodInfoPtr_get_Random_Private_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663728);
			DSAManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663729);
			DSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663730);
			DSAManaged.NativeMethodInfoPtr_NormalizeArray_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663731);
			DSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663732);
			DSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663733);
			DSAManaged.NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663734);
			DSAManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663735);
			DSAManaged.NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663736);
			DSAManaged.NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, 100663737);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00031584 File Offset: 0x0002F784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1279128, RefRangeEnd = 1279129, XrefRangeStart = 1279116, XrefRangeEnd = 1279128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSAManaged(int dwKeySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000315CC File Offset: 0x0002F7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00031608 File Offset: 0x0002F808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279129, XrefRangeEnd = 1279131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_Generate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0003163C File Offset: 0x0002F83C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1279159, RefRangeEnd = 1279161, XrefRangeStart = 1279131, XrefRangeEnd = 1279159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKeyPair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00031670 File Offset: 0x0002F870
		[CallerCount(0)]
		public unsafe void add(Il2CppStructArray<byte> a, Il2CppStructArray<byte> b, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_add_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000316D4 File Offset: 0x0002F8D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1279258, RefRangeEnd = 1279260, XrefRangeStart = 1279161, XrefRangeEnd = 1279258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateParams(int keyLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_GenerateParams_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00031714 File Offset: 0x0002F914
		public unsafe RandomNumberGenerator Random
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279260, XrefRangeEnd = 1279262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_get_Random_Private_get_RandomNumberGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00031754 File Offset: 0x0002F954
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0003179C File Offset: 0x0002F99C
		public unsafe bool PublicOnly
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1279263, RefRangeEnd = 1279265, XrefRangeStart = 1279262, XrefRangeEnd = 1279263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000317D8 File Offset: 0x0002F9D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1279266, RefRangeEnd = 1279273, XrefRangeStart = 1279265, XrefRangeEnd = 1279266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> NormalizeArray(Il2CppStructArray<byte> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_NormalizeArray_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00031828 File Offset: 0x0002FA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279273, XrefRangeEnd = 1279302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00031878 File Offset: 0x0002FA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279302, XrefRangeEnd = 1279350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ImportParameters(DSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000318CC File Offset: 0x0002FACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279350, XrefRangeEnd = 1279400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool VerifySignature(Il2CppStructArray<byte> rgbHash, Il2CppStructArray<byte> rgbSignature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbHash);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbSignature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00031938 File Offset: 0x0002FB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279400, XrefRangeEnd = 1279429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSAManaged.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00031984 File Offset: 0x0002FB84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1279433, RefRangeEnd = 1279434, XrefRangeStart = 1279429, XrefRangeEnd = 1279433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000319C8 File Offset: 0x0002FBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279434, XrefRangeEnd = 1279438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000337C File Offset: 0x0000157C
		public DSAManaged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00031A0C File Offset: 0x0002FC0C
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003385 File Offset: 0x00001585
		public unsafe bool keypairGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_keypairGenerated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_keypairGenerated)) = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00031A34 File Offset: 0x0002FC34
		// (set) Token: 0x0600030F RID: 783 RVA: 0x000033A0 File Offset: 0x000015A0
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00031A5C File Offset: 0x0002FC5C
		// (set) Token: 0x06000311 RID: 785 RVA: 0x000033BB File Offset: 0x000015BB
		public unsafe BigInteger p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_p);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_p), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00031A8C File Offset: 0x0002FC8C
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000033DA File Offset: 0x000015DA
		public unsafe BigInteger q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00031ABC File Offset: 0x0002FCBC
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000033F9 File Offset: 0x000015F9
		public unsafe BigInteger g
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_g);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_g), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00031AEC File Offset: 0x0002FCEC
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00003418 File Offset: 0x00001618
		public unsafe BigInteger x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_x);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00031B1C File Offset: 0x0002FD1C
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00003437 File Offset: 0x00001637
		public unsafe BigInteger y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_y);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_y), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00031B4C File Offset: 0x0002FD4C
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00003456 File Offset: 0x00001656
		public unsafe BigInteger j
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_j);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_j), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00031B7C File Offset: 0x0002FD7C
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00003475 File Offset: 0x00001675
		public unsafe BigInteger seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00031BAC File Offset: 0x0002FDAC
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00003494 File Offset: 0x00001694
		public unsafe int counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_counter)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00031BD4 File Offset: 0x0002FDD4
		// (set) Token: 0x06000321 RID: 801 RVA: 0x000034AF File Offset: 0x000016AF
		public unsafe bool j_missing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_j_missing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_j_missing)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00031BFC File Offset: 0x0002FDFC
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000034CA File Offset: 0x000016CA
		public unsafe RandomNumberGenerator rng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_rng);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_rng), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00031C2C File Offset: 0x0002FE2C
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000034E9 File Offset: 0x000016E9
		public unsafe DSAManaged.KeyGeneratedEventHandler KeyGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_KeyGenerated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DSAManaged.KeyGeneratedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAManaged.NativeFieldInfoPtr_KeyGenerated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_keypairGenerated;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_p;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_q;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_g;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_j;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_seed;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_counter;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_j_missing;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_KeyGenerated;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Private_Void_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKeyPair_Private_Void_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_add_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_GenerateParams_Private_Void_Int32_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_get_Random_Private_get_RandomNumberGenerator_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeArray_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_VerifySignature_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_add_KeyGenerated_Public_add_Void_KeyGeneratedEventHandler_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_remove_KeyGenerated_Public_rem_Void_KeyGeneratedEventHandler_0;

		// Token: 0x0200056F RID: 1391
		public sealed class KeyGeneratedEventHandler : MulticastDelegate
		{
			// Token: 0x060055DD RID: 21981 RVA: 0x0001E833 File Offset: 0x0001CA33
			// Note: this type is marked as 'beforefieldinit'.
			static KeyGeneratedEventHandler()
			{
				Il2CppClassPointerStore<DSAManaged.KeyGeneratedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DSAManaged>.NativeClassPtr, "KeyGeneratedEventHandler");
				DSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663738);
				DSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSAManaged.KeyGeneratedEventHandler>.NativeClassPtr, 100663739);
			}

			// Token: 0x060055DE RID: 21982 RVA: 0x0018CBE4 File Offset: 0x0018ADE4
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 313218, RefRangeEnd = 313223, XrefRangeStart = 313218, XrefRangeEnd = 313223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyGeneratedEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSAManaged.KeyGeneratedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055DF RID: 21983 RVA: 0x0018CC40 File Offset: 0x0018AE40
			[CallerCount(0)]
			public unsafe void Invoke(Object sender, EventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSAManaged.KeyGeneratedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055E0 RID: 21984 RVA: 0x0001E871 File Offset: 0x0001CA71
			public KeyGeneratedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060055E1 RID: 21985 RVA: 0x0001E87A File Offset: 0x0001CA7A
			public static implicit operator DSAManaged.KeyGeneratedEventHandler(Action<Object, EventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<DSAManaged.KeyGeneratedEventHandler>(A_0);
			}

			// Token: 0x060055E2 RID: 21986 RVA: 0x0001E882 File Offset: 0x0001CA82
			public static DSAManaged.KeyGeneratedEventHandler operator +(DSAManaged.KeyGeneratedEventHandler A_0, DSAManaged.KeyGeneratedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DSAManaged.KeyGeneratedEventHandler>();
			}

			// Token: 0x060055E3 RID: 21987 RVA: 0x0001E890 File Offset: 0x0001CA90
			public static DSAManaged.KeyGeneratedEventHandler operator -(DSAManaged.KeyGeneratedEventHandler A_0, DSAManaged.KeyGeneratedEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DSAManaged.KeyGeneratedEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400460E RID: 17934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400460F RID: 17935
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0;
		}
	}
}
