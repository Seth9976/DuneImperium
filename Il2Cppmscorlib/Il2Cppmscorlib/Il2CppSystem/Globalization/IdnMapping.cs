using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000496 RID: 1174
	public sealed class IdnMapping : Object
	{
		// Token: 0x0600490B RID: 18699 RVA: 0x001533B4 File Offset: 0x001515B4
		// Note: this type is marked as 'beforefieldinit'.
		static IdnMapping()
		{
			Il2CppClassPointerStore<IdnMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "IdnMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr);
			IdnMapping.NativeFieldInfoPtr_allow_unassigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, "allow_unassigned");
			IdnMapping.NativeFieldInfoPtr_use_std3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, "use_std3");
			IdnMapping.NativeFieldInfoPtr_puny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, "puny");
			IdnMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673956);
			IdnMapping.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673957);
			IdnMapping.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673958);
			IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673959);
			IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673960);
			IdnMapping.NativeMethodInfoPtr_Convert_Private_String_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673961);
			IdnMapping.NativeMethodInfoPtr_ToAscii_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673962);
			IdnMapping.NativeMethodInfoPtr_VerifyLength_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673963);
			IdnMapping.NativeMethodInfoPtr_NamePrep_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673964);
			IdnMapping.NativeMethodInfoPtr_VerifyProhibitedCharacters_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673965);
			IdnMapping.NativeMethodInfoPtr_VerifyStd3AsciiRules_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673966);
			IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673967);
			IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673968);
			IdnMapping.NativeMethodInfoPtr_ToUnicode_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100673969);
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x00153538 File Offset: 0x00151738
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1413985, RefRangeEnd = 1413988, XrefRangeStart = 1413979, XrefRangeEnd = 1413985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdnMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x00153574 File Offset: 0x00151774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413988, XrefRangeEnd = 1413990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x001535C4 File Offset: 0x001517C4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x00153600 File Offset: 0x00151800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1413991, RefRangeEnd = 1413993, XrefRangeStart = 1413990, XrefRangeEnd = 1413991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAscii(string unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unicode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x00153648 File Offset: 0x00151848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413993, XrefRangeEnd = 1413994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAscii(string unicode, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unicode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x001536AC File Offset: 0x001518AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1414019, RefRangeEnd = 1414023, XrefRangeStart = 1413994, XrefRangeEnd = 1414019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Convert(string input, int index, int count, bool toAscii)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toAscii;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_Convert_Private_String_String_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00153720 File Offset: 0x00151920
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1414037, RefRangeEnd = 1414039, XrefRangeStart = 1414023, XrefRangeEnd = 1414037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToAscii(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_ToAscii_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00153778 File Offset: 0x00151978
		[CallerCount(0)]
		public unsafe void VerifyLength(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_VerifyLength_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x001537C8 File Offset: 0x001519C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1414046, RefRangeEnd = 1414048, XrefRangeStart = 1414039, XrefRangeEnd = 1414046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NamePrep(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_NamePrep_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00153820 File Offset: 0x00151A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414058, RefRangeEnd = 1414059, XrefRangeStart = 1414048, XrefRangeEnd = 1414058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyProhibitedCharacters(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_VerifyProhibitedCharacters_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00153870 File Offset: 0x00151A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414063, RefRangeEnd = 1414064, XrefRangeStart = 1414059, XrefRangeEnd = 1414063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyStd3AsciiRules(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_VerifyStd3AsciiRules_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x001538C0 File Offset: 0x00151AC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1414065, RefRangeEnd = 1414068, XrefRangeStart = 1414064, XrefRangeEnd = 1414065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnicode(string ascii)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ascii);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x00153908 File Offset: 0x00151B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414068, XrefRangeEnd = 1414069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnicode(string ascii, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ascii);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x0015396C File Offset: 0x00151B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414084, RefRangeEnd = 1414085, XrefRangeStart = 1414069, XrefRangeEnd = 1414084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUnicode(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_ToUnicode_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x0001AA22 File Offset: 0x00018C22
		public IdnMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x0600491B RID: 18715 RVA: 0x001539C4 File Offset: 0x00151BC4
		// (set) Token: 0x0600491C RID: 18716 RVA: 0x0001AA2B File Offset: 0x00018C2B
		public unsafe bool allow_unassigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_allow_unassigned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_allow_unassigned)) = value;
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x0600491D RID: 18717 RVA: 0x001539EC File Offset: 0x00151BEC
		// (set) Token: 0x0600491E RID: 18718 RVA: 0x0001AA46 File Offset: 0x00018C46
		public unsafe bool use_std3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_use_std3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_use_std3)) = value;
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x0600491F RID: 18719 RVA: 0x00153A14 File Offset: 0x00151C14
		// (set) Token: 0x06004920 RID: 18720 RVA: 0x0001AA61 File Offset: 0x00018C61
		public unsafe Punycode puny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_puny);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Punycode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_puny), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BFB RID: 15355
		private static readonly IntPtr NativeFieldInfoPtr_allow_unassigned;

		// Token: 0x04003BFC RID: 15356
		private static readonly IntPtr NativeFieldInfoPtr_use_std3;

		// Token: 0x04003BFD RID: 15357
		private static readonly IntPtr NativeFieldInfoPtr_puny;

		// Token: 0x04003BFE RID: 15358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003BFF RID: 15359
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003C00 RID: 15360
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003C01 RID: 15361
		private static readonly IntPtr NativeMethodInfoPtr_GetAscii_Public_String_String_0;

		// Token: 0x04003C02 RID: 15362
		private static readonly IntPtr NativeMethodInfoPtr_GetAscii_Public_String_String_Int32_Int32_0;

		// Token: 0x04003C03 RID: 15363
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Private_String_String_Int32_Int32_Boolean_0;

		// Token: 0x04003C04 RID: 15364
		private static readonly IntPtr NativeMethodInfoPtr_ToAscii_Private_String_String_Int32_0;

		// Token: 0x04003C05 RID: 15365
		private static readonly IntPtr NativeMethodInfoPtr_VerifyLength_Private_Void_String_Int32_0;

		// Token: 0x04003C06 RID: 15366
		private static readonly IntPtr NativeMethodInfoPtr_NamePrep_Private_String_String_Int32_0;

		// Token: 0x04003C07 RID: 15367
		private static readonly IntPtr NativeMethodInfoPtr_VerifyProhibitedCharacters_Private_Void_String_Int32_0;

		// Token: 0x04003C08 RID: 15368
		private static readonly IntPtr NativeMethodInfoPtr_VerifyStd3AsciiRules_Private_Void_String_Int32_0;

		// Token: 0x04003C09 RID: 15369
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicode_Public_String_String_0;

		// Token: 0x04003C0A RID: 15370
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicode_Public_String_String_Int32_Int32_0;

		// Token: 0x04003C0B RID: 15371
		private static readonly IntPtr NativeMethodInfoPtr_ToUnicode_Private_String_String_Int32_0;
	}
}
