using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001B RID: 27
	public class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
	{
		// Token: 0x06000206 RID: 518 RVA: 0x0001D7D0 File Offset: 0x0001B9D0
		// Note: this type is marked as 'beforefieldinit'.
		static HtmlEncodedRawTextWriterIndent()
		{
			Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "HtmlEncodedRawTextWriterIndent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr);
			HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_indentLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, "indentLevel");
			HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_endBlockPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, "endBlockPos");
			HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_indentChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, "indentChars");
			HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_newLineOnAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, "newLineOnAttributes");
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663562);
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663563);
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663564);
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663565);
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663566);
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663567);
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663568);
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663569);
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_Init_Private_Void_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663570);
			HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteIndent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr, 100663571);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0001D918 File Offset: 0x0001BB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364411, XrefRangeEnd = 364414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HtmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0001D978 File Offset: 0x0001BB78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 364417, RefRangeEnd = 364418, XrefRangeStart = 364414, XrefRangeEnd = 364417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HtmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HtmlEncodedRawTextWriterIndent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0001D9D8 File Offset: 0x0001BBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364418, XrefRangeEnd = 364419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001DA5C File Offset: 0x0001BC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364419, XrefRangeEnd = 364430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001DAD0 File Offset: 0x0001BCD0
		[CallerCount(0)]
		public unsafe override void StartElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001DB0C File Offset: 0x0001BD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364430, XrefRangeEnd = 364437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0001DB80 File Offset: 0x0001BD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364437, XrefRangeEnd = 364441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364441, XrefRangeEnd = 364442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0001DC30 File Offset: 0x0001BE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364442, XrefRangeEnd = 364443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Init(XmlWriterSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_Init_Private_Void_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001DC74 File Offset: 0x0001BE74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 364445, RefRangeEnd = 364446, XrefRangeStart = 364443, XrefRangeEnd = 364445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HtmlEncodedRawTextWriterIndent.NativeMethodInfoPtr_WriteIndent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002D78 File Offset: 0x00000F78
		public HtmlEncodedRawTextWriterIndent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0001DCA8 File Offset: 0x0001BEA8
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002D81 File Offset: 0x00000F81
		public unsafe int indentLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_indentLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_indentLevel)) = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002D9C File Offset: 0x00000F9C
		public unsafe int endBlockPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_endBlockPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_endBlockPos)) = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0001DCF8 File Offset: 0x0001BEF8
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002DB7 File Offset: 0x00000FB7
		public unsafe string indentChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_indentChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_indentChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0001DD20 File Offset: 0x0001BF20
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002DD6 File Offset: 0x00000FD6
		public unsafe bool newLineOnAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_newLineOnAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HtmlEncodedRawTextWriterIndent.NativeFieldInfoPtr_newLineOnAttributes)) = value;
			}
		}

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_indentLevel;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_endBlockPos;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_indentChars;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_newLineOnAttributes;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextWriter_XmlWriterSettings_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Protected_Virtual_Void_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_XmlWriterSettings_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_WriteIndent_Private_Void_0;
	}
}
