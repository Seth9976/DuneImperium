using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019C RID: 412
	public class XmlSchemaAppInfo : XmlSchemaObject
	{
		// Token: 0x060023F0 RID: 9200 RVA: 0x000AAD20 File Offset: 0x000A8F20
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAppInfo()
		{
			Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAppInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr);
			XmlSchemaAppInfo.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, "source");
			XmlSchemaAppInfo.NativeFieldInfoPtr_markup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, "markup");
			XmlSchemaAppInfo.NativeMethodInfoPtr_set_Source_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, 100668516);
			XmlSchemaAppInfo.NativeMethodInfoPtr_get_Markup_Public_get_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, 100668517);
			XmlSchemaAppInfo.NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, 100668518);
			XmlSchemaAppInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, 100668519);
		}

		// Token: 0x17000C1B RID: 3099
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x000AADC8 File Offset: 0x000A8FC8
		public unsafe string Source
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAppInfo.NativeMethodInfoPtr_set_Source_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x000AAE0C File Offset: 0x000A900C
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x000AAE4C File Offset: 0x000A904C
		public unsafe Il2CppReferenceArray<XmlNode> Markup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAppInfo.NativeMethodInfoPtr_get_Markup_Public_get_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNode>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAppInfo.NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x000AAE90 File Offset: 0x000A9090
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAppInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAppInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0000F364 File Offset: 0x0000D564
		public XmlSchemaAppInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x000AAECC File Offset: 0x000A90CC
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x0000F36D File Offset: 0x0000D56D
		public unsafe string source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAppInfo.NativeFieldInfoPtr_source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAppInfo.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x000AAEF4 File Offset: 0x000A90F4
		// (set) Token: 0x060023F9 RID: 9209 RVA: 0x0000F38C File Offset: 0x0000D58C
		public unsafe Il2CppReferenceArray<XmlNode> markup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAppInfo.NativeFieldInfoPtr_markup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAppInfo.NativeFieldInfoPtr_markup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeFieldInfoPtr_markup;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_set_Void_String_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr_get_Markup_Public_get_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
