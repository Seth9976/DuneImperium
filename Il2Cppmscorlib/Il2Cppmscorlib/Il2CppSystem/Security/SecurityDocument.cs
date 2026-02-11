using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x0200021C RID: 540
	[Serializable]
	public sealed class SecurityDocument : Object
	{
		// Token: 0x060023DC RID: 9180 RVA: 0x000C9004 File Offset: 0x000C7204
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityDocument()
		{
			Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr);
			SecurityDocument.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, "m_data");
			SecurityDocument.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669352);
			SecurityDocument.NativeMethodInfoPtr_GuaranteeSize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669353);
			SecurityDocument.NativeMethodInfoPtr_AddString_Public_Void_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669354);
			SecurityDocument.NativeMethodInfoPtr_AppendString_Public_Void_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669355);
			SecurityDocument.NativeMethodInfoPtr_EncodedStringSize_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669356);
			SecurityDocument.NativeMethodInfoPtr_GetString_Public_String_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669357);
			SecurityDocument.NativeMethodInfoPtr_AddToken_Public_Void_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669358);
			SecurityDocument.NativeMethodInfoPtr_GetRootElement_Public_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669359);
			SecurityDocument.NativeMethodInfoPtr_GetElement_Public_SecurityElement_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669360);
			SecurityDocument.NativeMethodInfoPtr_InternalGetElement_Internal_SecurityElement_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr, 100669361);
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x000C9110 File Offset: 0x000C7310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369523, XrefRangeEnd = 1369528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityDocument(int numData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityDocument>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x000C9158 File Offset: 0x000C7358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369533, RefRangeEnd = 1369534, XrefRangeStart = 1369528, XrefRangeEnd = 1369533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuaranteeSize(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GuaranteeSize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x000C9198 File Offset: 0x000C7398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1369538, RefRangeEnd = 1369541, XrefRangeStart = 1369534, XrefRangeEnd = 1369538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddString(string str, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_AddString_Public_Void_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000C91E8 File Offset: 0x000C73E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1369549, RefRangeEnd = 1369551, XrefRangeStart = 1369541, XrefRangeEnd = 1369549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendString(string str, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_AppendString_Public_Void_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x000C9238 File Offset: 0x000C7438
		[CallerCount(0)]
		public unsafe static int EncodedStringSize(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_EncodedStringSize_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x000C927C File Offset: 0x000C747C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1369577, RefRangeEnd = 1369581, XrefRangeStart = 1369551, XrefRangeEnd = 1369577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(ref int position, bool bCreate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GetString_Public_String_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x000C92D0 File Offset: 0x000C74D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1369586, RefRangeEnd = 1369589, XrefRangeStart = 1369581, XrefRangeEnd = 1369586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToken(byte b, ref int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_AddToken_Public_Void_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x000C931C File Offset: 0x000C751C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369589, XrefRangeEnd = 1369590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement GetRootElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GetRootElement_Public_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x000C935C File Offset: 0x000C755C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369590, XrefRangeEnd = 1369591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement GetElement(int position, bool bCreate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_GetElement_Public_SecurityElement_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x000C93B8 File Offset: 0x000C75B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1369605, RefRangeEnd = 1369609, XrefRangeStart = 1369591, XrefRangeEnd = 1369605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement InternalGetElement(ref int position, bool bCreate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityDocument.NativeMethodInfoPtr_InternalGetElement_Internal_SecurityElement_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x0000B731 File Offset: 0x00009931
		public SecurityDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000C9414 File Offset: 0x000C7614
		// (set) Token: 0x060023E9 RID: 9193 RVA: 0x0000B73A File Offset: 0x0000993A
		public unsafe Il2CppStructArray<byte> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityDocument.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityDocument.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_GuaranteeSize_Public_Void_Int32_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_AddString_Public_Void_String_byref_Int32_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_AppendString_Public_Void_String_byref_Int32_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr_EncodedStringSize_Public_Static_Int32_String_0;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_byref_Int32_Boolean_0;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr_AddToken_Public_Void_Byte_byref_Int32_0;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr_GetRootElement_Public_SecurityElement_0;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_SecurityElement_Int32_Boolean_0;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetElement_Internal_SecurityElement_byref_Int32_Boolean_0;
	}
}
