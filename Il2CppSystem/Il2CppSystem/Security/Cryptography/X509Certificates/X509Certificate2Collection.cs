using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000CA RID: 202
	public class X509Certificate2Collection : X509CertificateCollection
	{
		// Token: 0x06000D60 RID: 3424 RVA: 0x0004E118 File Offset: 0x0004C318
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2Collection()
		{
			Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2Collection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr);
			X509Certificate2Collection.NativeFieldInfoPtr_newline_split = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, "newline_split");
			X509Certificate2Collection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, 100665217);
			X509Certificate2Collection.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, 100665218);
			X509Certificate2Collection.NativeMethodInfoPtr_get_Item_Public_get_X509Certificate2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, 100665219);
			X509Certificate2Collection.NativeMethodInfoPtr_Add_Public_Int32_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, 100665220);
			X509Certificate2Collection.NativeMethodInfoPtr_AddRange_Public_Void_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, 100665221);
			X509Certificate2Collection.NativeMethodInfoPtr_Contains_Public_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, 100665222);
			X509Certificate2Collection.NativeMethodInfoPtr_GetKeyIdentifier_Private_String_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, 100665223);
			X509Certificate2Collection.NativeMethodInfoPtr_Find_Public_X509Certificate2Collection_X509FindType_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, 100665224);
			X509Certificate2Collection.NativeMethodInfoPtr_GetEnumerator_Public_X509Certificate2Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, 100665225);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0004E210 File Offset: 0x0004C410
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 385162, RefRangeEnd = 385185, XrefRangeStart = 385162, XrefRangeEnd = 385185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Collection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Collection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0004E24C File Offset: 0x0004C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453700, XrefRangeEnd = 453708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Collection(X509Certificate2Collection certificates)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Collection.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000407 RID: 1031
		public unsafe X509Certificate2 this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 453710, RefRangeEnd = 453711, XrefRangeStart = 453708, XrefRangeEnd = 453710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Collection.NativeMethodInfoPtr_get_Item_Public_get_X509Certificate2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0004E2E4 File Offset: 0x0004C4E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453718, RefRangeEnd = 453719, XrefRangeStart = 453711, XrefRangeEnd = 453718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Collection.NativeMethodInfoPtr_Add_Public_Int32_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0004E334 File Offset: 0x0004C534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453719, XrefRangeEnd = 453726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(X509Certificate2Collection certificates)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Collection.NativeMethodInfoPtr_AddRange_Public_Void_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0004E378 File Offset: 0x0004C578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453735, RefRangeEnd = 453736, XrefRangeStart = 453726, XrefRangeEnd = 453735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Collection.NativeMethodInfoPtr_Contains_Public_Boolean_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0004E3C8 File Offset: 0x0004C5C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 453759, RefRangeEnd = 453760, XrefRangeStart = 453736, XrefRangeEnd = 453759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetKeyIdentifier(X509Certificate2 x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Collection.NativeMethodInfoPtr_GetKeyIdentifier_Private_String_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0004E410 File Offset: 0x0004C610
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 453865, RefRangeEnd = 453869, XrefRangeStart = 453760, XrefRangeEnd = 453865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Collection Find(X509FindType findType, Object findValue, bool validOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref findType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(findValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Collection.NativeMethodInfoPtr_Find_Public_X509Certificate2Collection_X509FindType_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr3) : null;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0004E47C File Offset: 0x0004C67C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 453877, RefRangeEnd = 453881, XrefRangeStart = 453869, XrefRangeEnd = 453877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe X509Certificate2Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Collection.NativeMethodInfoPtr_GetEnumerator_Public_X509Certificate2Enumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Enumerator>(intPtr3) : null;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00006F0F File Offset: 0x0000510F
		public X509Certificate2Collection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0004E4BC File Offset: 0x0004C6BC
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x00006F18 File Offset: 0x00005118
		public unsafe static Il2CppStringArray newline_split
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2Collection.NativeFieldInfoPtr_newline_split, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2Collection.NativeFieldInfoPtr_newline_split, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeFieldInfoPtr_newline_split;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Certificate2Collection_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509Certificate2_Int32_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_X509Certificate2_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_X509Certificate2Collection_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_X509Certificate2_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyIdentifier_Private_String_X509Certificate2_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_X509Certificate2Collection_X509FindType_Object_Boolean_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_X509Certificate2Enumerator_0;
	}
}
