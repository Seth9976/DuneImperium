using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200026D RID: 621
	public class TripleDES : SymmetricAlgorithm
	{
		// Token: 0x06002808 RID: 10248 RVA: 0x000D8804 File Offset: 0x000D6A04
		// Note: this type is marked as 'beforefieldinit'.
		static TripleDES()
		{
			Il2CppClassPointerStore<TripleDES>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "TripleDES");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TripleDES>.NativeClassPtr);
			TripleDES.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, "s_legalBlockSizes");
			TripleDES.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, "s_legalKeySizes");
			TripleDES.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100669887);
			TripleDES.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100669888);
			TripleDES.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100669889);
			TripleDES.NativeMethodInfoPtr_Create_Public_Static_TripleDES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100669890);
			TripleDES.NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100669891);
			TripleDES.NativeMethodInfoPtr_EqualBytes_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100669892);
			TripleDES.NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100669893);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000D88E8 File Offset: 0x000D6AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373949, XrefRangeEnd = 1373957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TripleDES()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TripleDES>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x000D8924 File Offset: 0x000D6B24
		// (set) Token: 0x0600280B RID: 10251 RVA: 0x000D8970 File Offset: 0x000D6B70
		public unsafe override Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373957, XrefRangeEnd = 1373964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TripleDES.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373964, XrefRangeEnd = 1373977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TripleDES.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000D89C0 File Offset: 0x000D6BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373981, RefRangeEnd = 1373982, XrefRangeStart = 1373977, XrefRangeEnd = 1373981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TripleDES Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr_Create_Public_Static_TripleDES_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TripleDES>(intPtr3) : null;
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000D89F4 File Offset: 0x000D6BF4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1373995, RefRangeEnd = 1374003, XrefRangeStart = 1373982, XrefRangeEnd = 1373995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWeakKey(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000D8A38 File Offset: 0x000D6C38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1374003, RefRangeEnd = 1374005, XrefRangeStart = 1374003, XrefRangeEnd = 1374003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualBytes(Il2CppStructArray<byte> rgbKey, int start1, int start2, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr_EqualBytes_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000D8AA4 File Offset: 0x000D6CA4
		[CallerCount(0)]
		public unsafe static bool IsLegalKeySize(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0000D2A1 File Offset: 0x0000B4A1
		public TripleDES(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x000D8AE8 File Offset: 0x000D6CE8
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x0000D2AA File Offset: 0x0000B4AA
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TripleDES.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TripleDES.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x000D8B10 File Offset: 0x000D6D10
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x0000D2BC File Offset: 0x0000B4BC
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TripleDES.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TripleDES.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TripleDES_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_EqualBytes_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0;
	}
}
