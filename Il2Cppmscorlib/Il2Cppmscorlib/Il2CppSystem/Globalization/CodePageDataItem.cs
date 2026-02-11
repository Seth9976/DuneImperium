using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200048F RID: 1167
	[Serializable]
	public class CodePageDataItem : Object
	{
		// Token: 0x0600481B RID: 18459 RVA: 0x0015075C File Offset: 0x0014E95C
		// Note: this type is marked as 'beforefieldinit'.
		static CodePageDataItem()
		{
			Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CodePageDataItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr);
			CodePageDataItem.NativeFieldInfoPtr_m_dataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_dataIndex");
			CodePageDataItem.NativeFieldInfoPtr_m_uiFamilyCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_uiFamilyCodePage");
			CodePageDataItem.NativeFieldInfoPtr_m_webName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_webName");
			CodePageDataItem.NativeFieldInfoPtr_m_headerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_headerName");
			CodePageDataItem.NativeFieldInfoPtr_m_bodyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_bodyName");
			CodePageDataItem.NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_flags");
			CodePageDataItem.NativeFieldInfoPtr_sep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "sep");
			CodePageDataItem.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100673875);
			CodePageDataItem.NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100673876);
			CodePageDataItem.NativeMethodInfoPtr_get_WebName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100673877);
			CodePageDataItem.NativeMethodInfoPtr_get_HeaderName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100673878);
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x00150868 File Offset: 0x0014EA68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411913, RefRangeEnd = 1411914, XrefRangeStart = 1411907, XrefRangeEnd = 1411913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CodePageDataItem(int dataIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dataIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x001508B0 File Offset: 0x0014EAB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411916, RefRangeEnd = 1411918, XrefRangeStart = 1411914, XrefRangeEnd = 1411916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateString(string pStrings, uint index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pStrings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x001508FC File Offset: 0x0014EAFC
		public unsafe string WebName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1411927, RefRangeEnd = 1411928, XrefRangeStart = 1411918, XrefRangeEnd = 1411927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr_get_WebName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x00150934 File Offset: 0x0014EB34
		public unsafe string HeaderName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1411937, RefRangeEnd = 1411938, XrefRangeStart = 1411928, XrefRangeEnd = 1411937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr_get_HeaderName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004820 RID: 18464 RVA: 0x0001A2DA File Offset: 0x000184DA
		public CodePageDataItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06004821 RID: 18465 RVA: 0x0015096C File Offset: 0x0014EB6C
		// (set) Token: 0x06004822 RID: 18466 RVA: 0x0001A2E3 File Offset: 0x000184E3
		public unsafe int m_dataIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_dataIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_dataIndex)) = value;
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x00150994 File Offset: 0x0014EB94
		// (set) Token: 0x06004824 RID: 18468 RVA: 0x0001A2FE File Offset: 0x000184FE
		public unsafe int m_uiFamilyCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_uiFamilyCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_uiFamilyCodePage)) = value;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x001509BC File Offset: 0x0014EBBC
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x0001A319 File Offset: 0x00018519
		public unsafe string m_webName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_webName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_webName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x001509E4 File Offset: 0x0014EBE4
		// (set) Token: 0x06004828 RID: 18472 RVA: 0x0001A338 File Offset: 0x00018538
		public unsafe string m_headerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_headerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_headerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x00150A0C File Offset: 0x0014EC0C
		// (set) Token: 0x0600482A RID: 18474 RVA: 0x0001A357 File Offset: 0x00018557
		public unsafe string m_bodyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_bodyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_bodyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x00150A34 File Offset: 0x0014EC34
		// (set) Token: 0x0600482C RID: 18476 RVA: 0x0001A376 File Offset: 0x00018576
		public unsafe uint m_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_flags)) = value;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x00150A5C File Offset: 0x0014EC5C
		// (set) Token: 0x0600482E RID: 18478 RVA: 0x0001A391 File Offset: 0x00018591
		public unsafe static Il2CppStructArray<char> sep
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CodePageDataItem.NativeFieldInfoPtr_sep, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePageDataItem.NativeFieldInfoPtr_sep, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B66 RID: 15206
		private static readonly IntPtr NativeFieldInfoPtr_m_dataIndex;

		// Token: 0x04003B67 RID: 15207
		private static readonly IntPtr NativeFieldInfoPtr_m_uiFamilyCodePage;

		// Token: 0x04003B68 RID: 15208
		private static readonly IntPtr NativeFieldInfoPtr_m_webName;

		// Token: 0x04003B69 RID: 15209
		private static readonly IntPtr NativeFieldInfoPtr_m_headerName;

		// Token: 0x04003B6A RID: 15210
		private static readonly IntPtr NativeFieldInfoPtr_m_bodyName;

		// Token: 0x04003B6B RID: 15211
		private static readonly IntPtr NativeFieldInfoPtr_m_flags;

		// Token: 0x04003B6C RID: 15212
		private static readonly IntPtr NativeFieldInfoPtr_sep;

		// Token: 0x04003B6D RID: 15213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04003B6E RID: 15214
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0;

		// Token: 0x04003B6F RID: 15215
		private static readonly IntPtr NativeMethodInfoPtr_get_WebName_Public_get_String_0;

		// Token: 0x04003B70 RID: 15216
		private static readonly IntPtr NativeMethodInfoPtr_get_HeaderName_Public_get_String_0;
	}
}
