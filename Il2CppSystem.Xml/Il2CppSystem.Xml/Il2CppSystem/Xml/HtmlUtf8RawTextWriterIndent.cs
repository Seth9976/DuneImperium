using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001E RID: 30
	public class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
	{
		// Token: 0x0600024B RID: 587 RVA: 0x0001E9CC File Offset: 0x0001CBCC
		// Note: this type is marked as 'beforefieldinit'.
		static HtmlUtf8RawTextWriterIndent()
		{
			Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "HtmlUtf8RawTextWriterIndent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr);
			HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, "indentLevel");
			HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_endBlockPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, "endBlockPos");
			HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, "indentChars");
			HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_newLineOnAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, "newLineOnAttributes");
			HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, 100663596);
			HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, 100663597);
			HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, 100663598);
			HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, 100663599);
			HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, 100663600);
			HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, 100663601);
			HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, 100663602);
			HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_Init_Private_Void_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, 100663603);
			HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteIndent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr, 100663604);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001EB00 File Offset: 0x0001CD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364639, XrefRangeEnd = 364641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HtmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HtmlUtf8RawTextWriterIndent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001EB60 File Offset: 0x0001CD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364641, XrefRangeEnd = 364642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sysid);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001EBE4 File Offset: 0x0001CDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364642, XrefRangeEnd = 364659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartElement(string prefix, string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001EC58 File Offset: 0x0001CE58
		[CallerCount(0)]
		public unsafe override void StartElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001EC94 File Offset: 0x0001CE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364659, XrefRangeEnd = 364664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEndElement(string prefix, string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001ED08 File Offset: 0x0001CF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364664, XrefRangeEnd = 364668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001ED7C File Offset: 0x0001CF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364668, XrefRangeEnd = 364669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001EDB8 File Offset: 0x0001CFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364669, XrefRangeEnd = 364670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Init(XmlWriterSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_Init_Private_Void_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0001EDFC File Offset: 0x0001CFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364670, XrefRangeEnd = 364672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HtmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteIndent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002F14 File Offset: 0x00001114
		public HtmlUtf8RawTextWriterIndent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0001EE30 File Offset: 0x0001D030
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002F1D File Offset: 0x0000111D
		public unsafe int indentLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentLevel)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0001EE58 File Offset: 0x0001D058
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00002F38 File Offset: 0x00001138
		public unsafe int endBlockPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_endBlockPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_endBlockPos)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0001EE80 File Offset: 0x0001D080
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002F53 File Offset: 0x00001153
		public unsafe string indentChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002F72 File Offset: 0x00001172
		public unsafe bool newLineOnAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_newLineOnAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_newLineOnAttributes)) = value;
			}
		}

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_indentLevel;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_endBlockPos;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_indentChars;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_newLineOnAttributes;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_Void_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_XmlWriterSettings_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_WriteIndent_Private_Void_0;
	}
}
