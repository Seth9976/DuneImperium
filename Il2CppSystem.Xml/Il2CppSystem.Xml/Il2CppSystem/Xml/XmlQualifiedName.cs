using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000A5 RID: 165
	[Serializable]
	public class XmlQualifiedName : Object
	{
		// Token: 0x060011B0 RID: 4528 RVA: 0x00064500 File Offset: 0x00062700
		// Note: this type is marked as 'beforefieldinit'.
		static XmlQualifiedName()
		{
			Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlQualifiedName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr);
			XmlQualifiedName.NativeFieldInfoPtr_hashCodeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "hashCodeDelegate");
			XmlQualifiedName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "name");
			XmlQualifiedName.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "ns");
			XmlQualifiedName.NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "hash");
			XmlQualifiedName.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "Empty");
			XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666226);
			XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666227);
			XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666228);
			XmlQualifiedName.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666229);
			XmlQualifiedName.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666230);
			XmlQualifiedName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666231);
			XmlQualifiedName.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666232);
			XmlQualifiedName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666233);
			XmlQualifiedName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666234);
			XmlQualifiedName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666235);
			XmlQualifiedName.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666236);
			XmlQualifiedName.NativeMethodInfoPtr_ToString_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666237);
			XmlQualifiedName.NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666238);
			XmlQualifiedName.NativeMethodInfoPtr_IsRandomizedHashingDisabled_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666239);
			XmlQualifiedName.NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666240);
			XmlQualifiedName.NativeMethodInfoPtr_Init_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666241);
			XmlQualifiedName.NativeMethodInfoPtr_SetNamespace_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666242);
			XmlQualifiedName.NativeMethodInfoPtr_Verify_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666243);
			XmlQualifiedName.NativeMethodInfoPtr_Atomize_Internal_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666244);
			XmlQualifiedName.NativeMethodInfoPtr_Parse_Internal_Static_XmlQualifiedName_String_IXmlNamespaceResolver_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666245);
			XmlQualifiedName.NativeMethodInfoPtr_Clone_Internal_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, 100666246);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00064738 File Offset: 0x00062938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 382566, RefRangeEnd = 382568, XrefRangeStart = 382557, XrefRangeEnd = 382566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00064774 File Offset: 0x00062974
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 382577, RefRangeEnd = 382644, XrefRangeStart = 382568, XrefRangeEnd = 382577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x000647C0 File Offset: 0x000629C0
		[CallerCount(151)]
		[CachedScanResults(RefRangeStart = 382651, RefRangeEnd = 382802, XrefRangeStart = 382644, XrefRangeEnd = 382651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName(string name, string ns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00064820 File Offset: 0x00062A20
		public unsafe string Namespace
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00064858 File Offset: 0x00062A58
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00064890 File Offset: 0x00062A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382802, XrefRangeEnd = 382814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlQualifiedName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000648D8 File Offset: 0x00062AD8
		public unsafe bool IsEmpty
		{
			[CallerCount(92)]
			[CachedScanResults(RefRangeStart = 382814, RefRangeEnd = 382906, XrefRangeStart = 382814, XrefRangeEnd = 382814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00064914 File Offset: 0x00062B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382906, XrefRangeEnd = 382907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlQualifiedName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00064958 File Offset: 0x00062B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382907, XrefRangeEnd = 382917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlQualifiedName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x000649B0 File Offset: 0x00062BB0
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 382919, RefRangeEnd = 383002, XrefRangeStart = 382917, XrefRangeEnd = 382919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(XmlQualifiedName a, XmlQualifiedName b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00064A04 File Offset: 0x00062C04
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 383007, RefRangeEnd = 383026, XrefRangeStart = 383002, XrefRangeEnd = 383007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(XmlQualifiedName a, XmlQualifiedName b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00064A58 File Offset: 0x00062C58
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 383029, RefRangeEnd = 383035, XrefRangeStart = 383026, XrefRangeEnd = 383029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(string name, string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_ToString_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00064AA8 File Offset: 0x00062CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383058, RefRangeEnd = 383059, XrefRangeStart = 383035, XrefRangeEnd = 383058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName.HashCodeOfStringDelegate>(intPtr3) : null;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00064ADC File Offset: 0x00062CDC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRandomizedHashingDisabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_IsRandomizedHashingDisabled_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00064B0C File Offset: 0x00062D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383059, XrefRangeEnd = 383060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCodeOfString(string s, int length, long additionalEntropy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00064B6C File Offset: 0x00062D6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 383062, RefRangeEnd = 383067, XrefRangeStart = 383060, XrefRangeEnd = 383062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_Init_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00064BC0 File Offset: 0x00062DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNamespace(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_SetNamespace_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00064C04 File Offset: 0x00062E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383074, RefRangeEnd = 383076, XrefRangeStart = 383067, XrefRangeEnd = 383074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Verify()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_Verify_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00064C38 File Offset: 0x00062E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383079, RefRangeEnd = 383081, XrefRangeStart = 383076, XrefRangeEnd = 383079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Atomize(XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_Atomize_Internal_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00064C7C File Offset: 0x00062E7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 383099, RefRangeEnd = 383103, XrefRangeStart = 383081, XrefRangeEnd = 383099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_Parse_Internal_Static_XmlQualifiedName_String_IXmlNamespaceResolver_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			prefix = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr4) : null;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00064CF0 File Offset: 0x00062EF0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 383106, RefRangeEnd = 383121, XrefRangeStart = 383103, XrefRangeEnd = 383106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.NativeMethodInfoPtr_Clone_Internal_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00007903 File Offset: 0x00005B03
		public XmlQualifiedName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x00064D30 File Offset: 0x00062F30
		// (set) Token: 0x060011C8 RID: 4552 RVA: 0x0000790C File Offset: 0x00005B0C
		public unsafe static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlQualifiedName.NativeFieldInfoPtr_hashCodeDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName.HashCodeOfStringDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlQualifiedName.NativeFieldInfoPtr_hashCodeDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x00064D58 File Offset: 0x00062F58
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x0000791E File Offset: 0x00005B1E
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x00064D80 File Offset: 0x00062F80
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0000793D File Offset: 0x00005B3D
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00064DA8 File Offset: 0x00062FA8
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x0000795C File Offset: 0x00005B5C
		public unsafe int hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_hash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlQualifiedName.NativeFieldInfoPtr_hash)) = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x00064DD0 File Offset: 0x00062FD0
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x00007977 File Offset: 0x00005B77
		public unsafe static XmlQualifiedName Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlQualifiedName.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlQualifiedName.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeFieldInfoPtr_hashCodeDelegate;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeFieldInfoPtr_hash;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_XmlQualifiedName_XmlQualifiedName_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_String_String_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_IsRandomizedHashingDisabled_Private_Static_Boolean_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_String_String_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_SetNamespace_Internal_Void_String_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_Verify_Internal_Void_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_Atomize_Internal_Void_XmlNameTable_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_XmlQualifiedName_String_IXmlNamespaceResolver_byref_String_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_XmlQualifiedName_0;

		// Token: 0x02000247 RID: 583
		public sealed class HashCodeOfStringDelegate : MulticastDelegate
		{
			// Token: 0x060030B5 RID: 12469 RVA: 0x000147C9 File Offset: 0x000129C9
			// Note: this type is marked as 'beforefieldinit'.
			static HashCodeOfStringDelegate()
			{
				Il2CppClassPointerStore<XmlQualifiedName.HashCodeOfStringDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlQualifiedName>.NativeClassPtr, "HashCodeOfStringDelegate");
				XmlQualifiedName.HashCodeOfStringDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName.HashCodeOfStringDelegate>.NativeClassPtr, 100666248);
				XmlQualifiedName.HashCodeOfStringDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlQualifiedName.HashCodeOfStringDelegate>.NativeClassPtr, 100666249);
			}

			// Token: 0x060030B6 RID: 12470 RVA: 0x000DAFD8 File Offset: 0x000D91D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HashCodeOfStringDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlQualifiedName.HashCodeOfStringDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.HashCodeOfStringDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030B7 RID: 12471 RVA: 0x000DB034 File Offset: 0x000D9234
			[CallerCount(0)]
			public unsafe int Invoke(string s, int sLen, long additionalEntropy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sLen;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlQualifiedName.HashCodeOfStringDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060030B8 RID: 12472 RVA: 0x00014807 File Offset: 0x00012A07
			public HashCodeOfStringDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060030B9 RID: 12473 RVA: 0x00014810 File Offset: 0x00012A10
			public static implicit operator XmlQualifiedName.HashCodeOfStringDelegate(Func<string, int, long, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<XmlQualifiedName.HashCodeOfStringDelegate>(A_0);
			}

			// Token: 0x060030BA RID: 12474 RVA: 0x00014818 File Offset: 0x00012A18
			public static XmlQualifiedName.HashCodeOfStringDelegate operator +(XmlQualifiedName.HashCodeOfStringDelegate A_0, XmlQualifiedName.HashCodeOfStringDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XmlQualifiedName.HashCodeOfStringDelegate>();
			}

			// Token: 0x060030BB RID: 12475 RVA: 0x00014826 File Offset: 0x00012A26
			public static XmlQualifiedName.HashCodeOfStringDelegate operator -(XmlQualifiedName.HashCodeOfStringDelegate A_0, XmlQualifiedName.HashCodeOfStringDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XmlQualifiedName.HashCodeOfStringDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040025D6 RID: 9686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040025D7 RID: 9687
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0;
		}
	}
}
