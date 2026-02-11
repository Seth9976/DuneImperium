using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000239 RID: 569
	public sealed class KeySizes : Object
	{
		// Token: 0x06002583 RID: 9603 RVA: 0x000CF424 File Offset: 0x000CD624
		// Note: this type is marked as 'beforefieldinit'.
		static KeySizes()
		{
			Il2CppClassPointerStore<KeySizes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "KeySizes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeySizes>.NativeClassPtr);
			KeySizes.NativeFieldInfoPtr_m_minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, "m_minSize");
			KeySizes.NativeFieldInfoPtr_m_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, "m_maxSize");
			KeySizes.NativeFieldInfoPtr_m_skipSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, "m_skipSize");
			KeySizes.NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669582);
			KeySizes.NativeMethodInfoPtr_get_MaxSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669583);
			KeySizes.NativeMethodInfoPtr_get_SkipSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669584);
			KeySizes.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669585);
			KeySizes.NativeMethodInfoPtr_IsLegal_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669586);
			KeySizes.NativeMethodInfoPtr_IsLegalKeySize_Internal_Static_Boolean_Il2CppReferenceArray_1_KeySizes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669587);
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x000CF508 File Offset: 0x000CD708
		public unsafe int MinSize
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x000CF544 File Offset: 0x000CD744
		public unsafe int MaxSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_get_MaxSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x000CF580 File Offset: 0x000CD780
		public unsafe int SkipSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_get_SkipSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000CF5BC File Offset: 0x000CD7BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 904096, RefRangeEnd = 904103, XrefRangeStart = 904096, XrefRangeEnd = 904103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeySizes(int minSize, int maxSize, int skipSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeySizes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x000CF620 File Offset: 0x000CD820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371575, XrefRangeEnd = 1371576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLegal(int keySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_IsLegal_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x000CF66C File Offset: 0x000CD86C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1371578, RefRangeEnd = 1371579, XrefRangeStart = 1371576, XrefRangeEnd = 1371578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLegalKeySize(Il2CppReferenceArray<KeySizes> legalKeys, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(legalKeys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_IsLegalKeySize_Internal_Static_Boolean_Il2CppReferenceArray_1_KeySizes_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x0000C23E File Offset: 0x0000A43E
		public KeySizes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x000CF6BC File Offset: 0x000CD8BC
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x0000C247 File Offset: 0x0000A447
		public unsafe int m_minSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_minSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_minSize)) = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x000CF6E4 File Offset: 0x000CD8E4
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x0000C262 File Offset: 0x0000A462
		public unsafe int m_maxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_maxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_maxSize)) = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x000CF70C File Offset: 0x000CD90C
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x0000C27D File Offset: 0x0000A47D
		public unsafe int m_skipSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_skipSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_skipSize)) = value;
			}
		}

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeFieldInfoPtr_m_minSize;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeFieldInfoPtr_m_maxSize;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeFieldInfoPtr_m_skipSize;

		// Token: 0x040020A7 RID: 8359
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0;

		// Token: 0x040020A8 RID: 8360
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSize_Public_get_Int32_0;

		// Token: 0x040020A9 RID: 8361
		private static readonly IntPtr NativeMethodInfoPtr_get_SkipSize_Public_get_Int32_0;

		// Token: 0x040020AA RID: 8362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040020AB RID: 8363
		private static readonly IntPtr NativeMethodInfoPtr_IsLegal_Internal_Boolean_Int32_0;

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeMethodInfoPtr_IsLegalKeySize_Internal_Static_Boolean_Il2CppReferenceArray_1_KeySizes_Int32_0;
	}
}
