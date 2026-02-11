using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200008A RID: 138
	public static class ValidateNames : Object
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x0005CAC8 File Offset: 0x0005ACC8
		// Note: this type is marked as 'beforefieldinit'.
		static ValidateNames()
		{
			Il2CppClassPointerStore<ValidateNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ValidateNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr);
			ValidateNames.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, "xmlCharType");
			ValidateNames.NativeMethodInfoPtr_ParseNmtoken_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665952);
			ValidateNames.NativeMethodInfoPtr_ParseNmtokenNoNamespaces_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665953);
			ValidateNames.NativeMethodInfoPtr_ParseNameNoNamespaces_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665954);
			ValidateNames.NativeMethodInfoPtr_IsNameNoNamespaces_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665955);
			ValidateNames.NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665956);
			ValidateNames.NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665957);
			ValidateNames.NativeMethodInfoPtr_ParseQName_Internal_Static_Int32_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665958);
			ValidateNames.NativeMethodInfoPtr_ParseQNameThrow_Internal_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665959);
			ValidateNames.NativeMethodInfoPtr_ThrowInvalidName_Internal_Static_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665960);
			ValidateNames.NativeMethodInfoPtr_GetInvalidNameException_Internal_Static_Exception_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665961);
			ValidateNames.NativeMethodInfoPtr_SplitQName_Internal_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100665962);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0005CBE8 File Offset: 0x0005ADE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379792, RefRangeEnd = 379793, XrefRangeStart = 379786, XrefRangeEnd = 379792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNmtoken(string s, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNmtoken_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0005CC38 File Offset: 0x0005AE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379793, XrefRangeEnd = 379800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNmtokenNoNamespaces(string s, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNmtokenNoNamespaces_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0005CC88 File Offset: 0x0005AE88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 379806, RefRangeEnd = 379809, XrefRangeStart = 379800, XrefRangeEnd = 379806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNameNoNamespaces(string s, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNameNoNamespaces_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0005CCD8 File Offset: 0x0005AED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379813, RefRangeEnd = 379814, XrefRangeStart = 379809, XrefRangeEnd = 379813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNameNoNamespaces(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_IsNameNoNamespaces_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0005CD1C File Offset: 0x0005AF1C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 379819, RefRangeEnd = 379831, XrefRangeStart = 379814, XrefRangeEnd = 379819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNCName(string s, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0005CD6C File Offset: 0x0005AF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379831, XrefRangeEnd = 379835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseNCName(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0005CDB0 File Offset: 0x0005AFB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379843, RefRangeEnd = 379845, XrefRangeStart = 379835, XrefRangeEnd = 379843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseQName(string s, int offset, out int colonOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &colonOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseQName_Internal_Static_Int32_String_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0005CE10 File Offset: 0x0005B010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379869, RefRangeEnd = 379871, XrefRangeStart = 379845, XrefRangeEnd = 379869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseQNameThrow(string s, out string prefix, out string localName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ParseQNameThrow_Internal_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			prefix = IL2CPP.Il2CppStringToManaged(intPtr);
			localName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0005CE7C File Offset: 0x0005B07C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379906, RefRangeEnd = 379907, XrefRangeStart = 379871, XrefRangeEnd = 379906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetStartChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetBadChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_ThrowInvalidName_Internal_Static_Void_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0005CED0 File Offset: 0x0005B0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379907, XrefRangeEnd = 379928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetStartChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetBadChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_GetInvalidNameException_Internal_Static_Exception_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0005CF30 File Offset: 0x0005B130
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 379947, RefRangeEnd = 379950, XrefRangeStart = 379928, XrefRangeEnd = 379947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitQName(string name, out string prefix, out string lname)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ValidateNames.NativeMethodInfoPtr_SplitQName_Internal_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			prefix = IL2CPP.Il2CppStringToManaged(intPtr);
			lname = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00007466 File Offset: 0x00005666
		public ValidateNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0005CF9C File Offset: 0x0005B19C
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x0000746F File Offset: 0x0000566F
		public unsafe static XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ValidateNames.NativeFieldInfoPtr_xmlCharType, intPtr);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidateNames.NativeFieldInfoPtr_xmlCharType, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_ParseNmtoken_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_ParseNmtokenNoNamespaces_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_ParseNameNoNamespaces_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_IsNameNoNamespaces_Internal_Static_Boolean_String_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_Int32_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Internal_Static_Int32_String_Int32_byref_Int32_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_ParseQNameThrow_Internal_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidName_Internal_Static_Void_String_Int32_Int32_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidNameException_Internal_Static_Exception_String_Int32_Int32_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_SplitQName_Internal_Static_Void_String_byref_String_byref_String_0;
	}
}
