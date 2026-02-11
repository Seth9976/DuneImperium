using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000234 RID: 564
	public class AsymmetricAlgorithm : Object
	{
		// Token: 0x0600256C RID: 9580 RVA: 0x000CEEAC File Offset: 0x000CD0AC
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricAlgorithm()
		{
			Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "AsymmetricAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr);
			AsymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, "KeySizeValue");
			AsymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, "LegalKeySizesValue");
			AsymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100669569);
			AsymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100669570);
			AsymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100669571);
			AsymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100669572);
			AsymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100669573);
			AsymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100669574);
			AsymmetricAlgorithm.NativeMethodInfoPtr_FromXmlString_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100669575);
			AsymmetricAlgorithm.NativeMethodInfoPtr_ToXmlString_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100669576);
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x000CEFA4 File Offset: 0x000CD1A4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricAlgorithm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000CEFE0 File Offset: 0x000CD1E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371556, RefRangeEnd = 1371558, XrefRangeStart = 1371552, XrefRangeEnd = 1371556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000CF014 File Offset: 0x000CD214
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371556, RefRangeEnd = 1371558, XrefRangeStart = 1371556, XrefRangeEnd = 1371558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x000CF048 File Offset: 0x000CD248
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x000CF094 File Offset: 0x000CD294
		// (set) Token: 0x06002572 RID: 9586 RVA: 0x000CF0DC File Offset: 0x000CD2DC
		public unsafe virtual int KeySize
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1371561, RefRangeEnd = 1371565, XrefRangeStart = 1371558, XrefRangeEnd = 1371561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000CF128 File Offset: 0x000CD328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371565, XrefRangeEnd = 1371570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FromXmlString(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_FromXmlString_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x000CF178 File Offset: 0x000CD378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371570, XrefRangeEnd = 1371575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToXmlString(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_ToXmlString_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		public AsymmetricAlgorithm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000CF1C8 File Offset: 0x000CD3C8
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x0000C1B9 File Offset: 0x0000A3B9
		public unsafe int KeySizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue)) = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x000CF1F0 File Offset: 0x000CD3F0
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		public unsafe Il2CppReferenceArray<KeySizes> LegalKeySizesValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeFieldInfoPtr_KeySizeValue;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeFieldInfoPtr_LegalKeySizesValue;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlString_Public_Virtual_New_Void_String_0;

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_Virtual_New_String_Boolean_0;
	}
}
