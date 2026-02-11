using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200008B RID: 139
	public sealed class XmlCharType : ValueType
	{
		// Token: 0x0600103D RID: 4157 RVA: 0x0005CFD8 File Offset: 0x0005B1D8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCharType()
		{
			Il2CppClassPointerStore<XmlCharType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlCharType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr);
			XmlCharType.NativeFieldInfoPtr_s_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, "s_Lock");
			XmlCharType.NativeFieldInfoPtr_s_CharProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, "s_CharProperties");
			XmlCharType.NativeFieldInfoPtr_charProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, "charProperties");
			XmlCharType.NativeMethodInfoPtr_get_StaticLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665964);
			XmlCharType.NativeMethodInfoPtr_InitInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665965);
			XmlCharType.NativeMethodInfoPtr_SetProperties_Private_Static_Void_Il2CppStructArray_1_Byte_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665966);
			XmlCharType.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665967);
			XmlCharType.NativeMethodInfoPtr_get_Instance_Public_Static_get_XmlCharType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665968);
			XmlCharType.NativeMethodInfoPtr_IsWhiteSpace_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665969);
			XmlCharType.NativeMethodInfoPtr_IsNCNameSingleChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665970);
			XmlCharType.NativeMethodInfoPtr_IsStartNCNameSingleChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665971);
			XmlCharType.NativeMethodInfoPtr_IsNameSingleChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665972);
			XmlCharType.NativeMethodInfoPtr_IsCharData_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665973);
			XmlCharType.NativeMethodInfoPtr_IsPubidChar_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665974);
			XmlCharType.NativeMethodInfoPtr_IsTextChar_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665975);
			XmlCharType.NativeMethodInfoPtr_IsLetter_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665976);
			XmlCharType.NativeMethodInfoPtr_IsNCNameCharXml4e_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665977);
			XmlCharType.NativeMethodInfoPtr_IsStartNCNameCharXml4e_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665978);
			XmlCharType.NativeMethodInfoPtr_IsNameCharXml4e_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665979);
			XmlCharType.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665980);
			XmlCharType.NativeMethodInfoPtr_IsHighSurrogate_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665981);
			XmlCharType.NativeMethodInfoPtr_IsLowSurrogate_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665982);
			XmlCharType.NativeMethodInfoPtr_IsSurrogate_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665983);
			XmlCharType.NativeMethodInfoPtr_CombineSurrogateChar_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665984);
			XmlCharType.NativeMethodInfoPtr_SplitSurrogateChar_Internal_Static_Void_Int32_byref_Char_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665985);
			XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespace_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665986);
			XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespaceWithPos_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665987);
			XmlCharType.NativeMethodInfoPtr_IsOnlyCharData_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665988);
			XmlCharType.NativeMethodInfoPtr_IsOnlyDigits_Internal_Static_Boolean_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665989);
			XmlCharType.NativeMethodInfoPtr_IsPublicId_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665990);
			XmlCharType.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, 100665991);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x0005D274 File Offset: 0x0005B474
		public unsafe static Object StaticLock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379950, XrefRangeEnd = 379959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_get_StaticLock_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0005D2A8 File Offset: 0x0005B4A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380032, RefRangeEnd = 380034, XrefRangeStart = 379959, XrefRangeEnd = 380032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_InitInstance_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0005D2D0 File Offset: 0x0005B4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380034, XrefRangeEnd = 380037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProperties(Il2CppStructArray<byte> chProps, string ranges, byte value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chProps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ranges);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_SetProperties_Private_Static_Void_Il2CppStructArray_1_Byte_String_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0005D328 File Offset: 0x0005B528
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlCharType(Il2CppStructArray<byte> charProperties)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(charProperties);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0005D378 File Offset: 0x0005B578
		public unsafe static XmlCharType Instance
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 380044, RefRangeEnd = 380071, XrefRangeStart = 380037, XrefRangeEnd = 380044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_get_Instance_Public_Static_get_XmlCharType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new XmlCharType(intPtr);
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0005D3A4 File Offset: 0x0005B5A4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 380071, RefRangeEnd = 380082, XrefRangeStart = 380071, XrefRangeEnd = 380071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWhiteSpace(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsWhiteSpace_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0005D3F4 File Offset: 0x0005B5F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 380082, RefRangeEnd = 380086, XrefRangeStart = 380082, XrefRangeEnd = 380082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNCNameSingleChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNCNameSingleChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0005D444 File Offset: 0x0005B644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380086, RefRangeEnd = 380088, XrefRangeStart = 380086, XrefRangeEnd = 380086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStartNCNameSingleChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsStartNCNameSingleChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0005D494 File Offset: 0x0005B694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380088, RefRangeEnd = 380090, XrefRangeStart = 380088, XrefRangeEnd = 380088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameSingleChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNameSingleChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0005D4E4 File Offset: 0x0005B6E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380090, RefRangeEnd = 380092, XrefRangeStart = 380090, XrefRangeEnd = 380090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCharData(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsCharData_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0005D534 File Offset: 0x0005B734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380093, RefRangeEnd = 380094, XrefRangeStart = 380092, XrefRangeEnd = 380093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPubidChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsPubidChar_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0005D584 File Offset: 0x0005B784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380094, RefRangeEnd = 380096, XrefRangeStart = 380094, XrefRangeEnd = 380094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTextChar(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsTextChar_Internal_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0005D5D4 File Offset: 0x0005B7D4
		[CallerCount(0)]
		public unsafe bool IsLetter(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsLetter_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0005D624 File Offset: 0x0005B824
		[CallerCount(0)]
		public unsafe bool IsNCNameCharXml4e(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNCNameCharXml4e_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0005D674 File Offset: 0x0005B874
		[CallerCount(0)]
		public unsafe bool IsStartNCNameCharXml4e(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsStartNCNameCharXml4e_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0005D6C4 File Offset: 0x0005B8C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380096, RefRangeEnd = 380097, XrefRangeStart = 380096, XrefRangeEnd = 380096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameCharXml4e(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsNameCharXml4e_Public_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0005D714 File Offset: 0x0005B914
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 380097, RefRangeEnd = 380109, XrefRangeStart = 380097, XrefRangeEnd = 380097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0005D754 File Offset: 0x0005B954
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 380109, RefRangeEnd = 380127, XrefRangeStart = 380109, XrefRangeEnd = 380109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHighSurrogate(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsHighSurrogate_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0005D794 File Offset: 0x0005B994
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 380127, RefRangeEnd = 380147, XrefRangeStart = 380127, XrefRangeEnd = 380127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLowSurrogate(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsLowSurrogate_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0005D7D4 File Offset: 0x0005B9D4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 380147, RefRangeEnd = 380163, XrefRangeStart = 380147, XrefRangeEnd = 380147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSurrogate(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsSurrogate_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0005D814 File Offset: 0x0005BA14
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 380163, RefRangeEnd = 380169, XrefRangeStart = 380163, XrefRangeEnd = 380163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineSurrogateChar(int lowChar, int highChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lowChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_CombineSurrogateChar_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0005D860 File Offset: 0x0005BA60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380169, RefRangeEnd = 380170, XrefRangeStart = 380169, XrefRangeEnd = 380169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref combinedChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lowChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &highChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_SplitSurrogateChar_Internal_Static_Void_Int32_byref_Char_byref_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0005D8B0 File Offset: 0x0005BAB0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 380172, RefRangeEnd = 380183, XrefRangeStart = 380170, XrefRangeEnd = 380172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOnlyWhitespace(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespace_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0005D904 File Offset: 0x0005BB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380183, XrefRangeEnd = 380186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IsOnlyWhitespaceWithPos(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyWhitespaceWithPos_Internal_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0005D958 File Offset: 0x0005BB58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 380191, RefRangeEnd = 380194, XrefRangeStart = 380186, XrefRangeEnd = 380191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IsOnlyCharData(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyCharData_Internal_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0005D9AC File Offset: 0x0005BBAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 380195, RefRangeEnd = 380198, XrefRangeStart = 380194, XrefRangeEnd = 380195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOnlyDigits(string str, int startPos, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsOnlyDigits_Internal_Static_Boolean_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0005DA0C File Offset: 0x0005BC0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 380201, RefRangeEnd = 380204, XrefRangeStart = 380198, XrefRangeEnd = 380201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IsPublicId(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_IsPublicId_Internal_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0005DA60 File Offset: 0x0005BC60
		[CallerCount(0)]
		public unsafe static bool InRange(int value, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharType.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00007486 File Offset: 0x00005686
		public XmlCharType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0000748F File Offset: 0x0000568F
		public XmlCharType()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr))
		{
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0005DABC File Offset: 0x0005BCBC
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x000074A1 File Offset: 0x000056A1
		public unsafe static Object s_Lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlCharType.NativeFieldInfoPtr_s_Lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlCharType.NativeFieldInfoPtr_s_Lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x0005DAE4 File Offset: 0x0005BCE4
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x000074B3 File Offset: 0x000056B3
		public unsafe static Il2CppStructArray<byte> s_CharProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlCharType.NativeFieldInfoPtr_s_CharProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlCharType.NativeFieldInfoPtr_s_CharProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x0005DB0C File Offset: 0x0005BD0C
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x000074C5 File Offset: 0x000056C5
		public unsafe Il2CppStructArray<byte> charProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCharType.NativeFieldInfoPtr_charProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCharType.NativeFieldInfoPtr_charProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr_s_Lock;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeFieldInfoPtr_s_CharProperties;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeFieldInfoPtr_charProperties;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticLock_Private_Static_get_Object_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_InitInstance_Private_Static_Void_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Private_Static_Void_Il2CppStructArray_1_Byte_String_Byte_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_XmlCharType_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Public_Boolean_Char_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_IsNCNameSingleChar_Public_Boolean_Char_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_IsStartNCNameSingleChar_Public_Boolean_Char_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_IsNameSingleChar_Public_Boolean_Char_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_IsCharData_Public_Boolean_Char_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_IsPubidChar_Public_Boolean_Char_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_IsTextChar_Internal_Boolean_Char_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_IsLetter_Public_Boolean_Char_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_IsNCNameCharXml4e_Public_Boolean_Char_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_IsStartNCNameCharXml4e_Public_Boolean_Char_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_IsNameCharXml4e_Public_Boolean_Char_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_IsLowSurrogate_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogate_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_CombineSurrogateChar_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_SplitSurrogateChar_Internal_Static_Void_Int32_byref_Char_byref_Char_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyWhitespace_Internal_Boolean_String_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyWhitespaceWithPos_Internal_Int32_String_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyCharData_Internal_Int32_String_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyDigits_Internal_Static_Boolean_String_Int32_Int32_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_IsPublicId_Internal_Int32_String_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0;
	}
}
