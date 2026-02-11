using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000232 RID: 562
	public sealed class HashAlgorithmName : ValueType
	{
		// Token: 0x06002555 RID: 9557 RVA: 0x000CE9A4 File Offset: 0x000CCBA4
		// Note: this type is marked as 'beforefieldinit'.
		static HashAlgorithmName()
		{
			Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HashAlgorithmName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr);
			HashAlgorithmName.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, "_name");
			HashAlgorithmName.NativeMethodInfoPtr_get_SHA1_Public_Static_get_HashAlgorithmName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669556);
			HashAlgorithmName.NativeMethodInfoPtr_get_SHA256_Public_Static_get_HashAlgorithmName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669557);
			HashAlgorithmName.NativeMethodInfoPtr_get_SHA384_Public_Static_get_HashAlgorithmName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669558);
			HashAlgorithmName.NativeMethodInfoPtr_get_SHA512_Public_Static_get_HashAlgorithmName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669559);
			HashAlgorithmName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669560);
			HashAlgorithmName.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669561);
			HashAlgorithmName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669562);
			HashAlgorithmName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669563);
			HashAlgorithmName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HashAlgorithmName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669564);
			HashAlgorithmName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669565);
			HashAlgorithmName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HashAlgorithmName_HashAlgorithmName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, 100669566);
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x000CEAC4 File Offset: 0x000CCCC4
		public unsafe static HashAlgorithmName SHA1
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1371516, RefRangeEnd = 1371518, XrefRangeStart = 1371513, XrefRangeEnd = 1371516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_get_SHA1_Public_Static_get_HashAlgorithmName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new HashAlgorithmName(intPtr);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x000CEAF0 File Offset: 0x000CCCF0
		public unsafe static HashAlgorithmName SHA256
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1371521, RefRangeEnd = 1371522, XrefRangeStart = 1371518, XrefRangeEnd = 1371521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_get_SHA256_Public_Static_get_HashAlgorithmName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new HashAlgorithmName(intPtr);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000CEB1C File Offset: 0x000CCD1C
		public unsafe static HashAlgorithmName SHA384
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1371525, RefRangeEnd = 1371526, XrefRangeStart = 1371522, XrefRangeEnd = 1371525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_get_SHA384_Public_Static_get_HashAlgorithmName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new HashAlgorithmName(intPtr);
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x000CEB48 File Offset: 0x000CCD48
		public unsafe static HashAlgorithmName SHA512
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1371529, RefRangeEnd = 1371530, XrefRangeStart = 1371526, XrefRangeEnd = 1371529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_get_SHA512_Public_Static_get_HashAlgorithmName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new HashAlgorithmName(intPtr);
			}
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000CEB74 File Offset: 0x000CCD74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashAlgorithmName(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x000CEBC4 File Offset: 0x000CCDC4
		public unsafe string Name
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000CEC00 File Offset: 0x000CCE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371530, XrefRangeEnd = 1371532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000CEC3C File Offset: 0x000CCE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371532, XrefRangeEnd = 1371536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000CEC90 File Offset: 0x000CCE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371536, XrefRangeEnd = 1371537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HashAlgorithmName other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HashAlgorithmName_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000CECE8 File Offset: 0x000CCEE8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000CED2C File Offset: 0x000CCF2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1371538, RefRangeEnd = 1371542, XrefRangeStart = 1371537, XrefRangeEnd = 1371538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HashAlgorithmName left, HashAlgorithmName right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithmName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HashAlgorithmName_HashAlgorithmName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x0000C149 File Offset: 0x0000A349
		public HashAlgorithmName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x0000C152 File Offset: 0x0000A352
		public HashAlgorithmName()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr))
		{
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x000CED8C File Offset: 0x000CCF8C
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x0000C164 File Offset: 0x0000A364
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithmName.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithmName.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeMethodInfoPtr_get_SHA1_Public_Static_get_HashAlgorithmName_0;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeMethodInfoPtr_get_SHA256_Public_Static_get_HashAlgorithmName_0;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr_get_SHA384_Public_Static_get_HashAlgorithmName_0;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeMethodInfoPtr_get_SHA512_Public_Static_get_HashAlgorithmName_0;

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HashAlgorithmName_0;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HashAlgorithmName_HashAlgorithmName_0;
	}
}
