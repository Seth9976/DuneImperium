using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200004F RID: 79
	public class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x0003C6AC File Offset: 0x0003A8AC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUtf8RawTextWriterIndent()
		{
			Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlUtf8RawTextWriterIndent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr);
			XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, "indentLevel");
			XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_newLineOnAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, "newLineOnAttributes");
			XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, "indentChars");
			XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_mixedContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, "mixedContent");
			XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_mixedContentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, "mixedContentStack");
			XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_conformanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, "conformanceLevel");
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664759);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664760);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664761);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664762);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_OnRootElement_Internal_Virtual_Void_ConformanceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664763);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664764);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664765);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664766);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664767);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664768);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664769);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664770);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664771);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664772);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664773);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664774);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664775);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664776);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664777);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664778);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_Init_Private_Void_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664779);
			XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteIndent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr, 100664780);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0003C90C File Offset: 0x0003AB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371272, XrefRangeEnd = 371285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUtf8RawTextWriterIndent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0003C96C File Offset: 0x0003AB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371285, XrefRangeEnd = 371287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371287, XrefRangeEnd = 371293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0003CA64 File Offset: 0x0003AC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371293, XrefRangeEnd = 371295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0003CAA0 File Offset: 0x0003ACA0
		[CallerCount(0)]
		public unsafe override void OnRootElement(ConformanceLevel currentConformanceLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentConformanceLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_OnRootElement_Internal_Virtual_Void_ConformanceLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0003CAEC File Offset: 0x0003ACEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371295, XrefRangeEnd = 371299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0003CB60 File Offset: 0x0003AD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371299, XrefRangeEnd = 371305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteFullEndElement(string prefix, string localName, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0003CBD4 File Offset: 0x0003ADD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371305, XrefRangeEnd = 371310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0003CC48 File Offset: 0x0003AE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371310, XrefRangeEnd = 371311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCData(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0003CC98 File Offset: 0x0003AE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371311, XrefRangeEnd = 371313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0003CCE8 File Offset: 0x0003AEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371313, XrefRangeEnd = 371317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteProcessingInstruction(string target, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0003CD48 File Offset: 0x0003AF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371317, XrefRangeEnd = 371319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0003CD98 File Offset: 0x0003AF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371319, XrefRangeEnd = 371320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0003CDE4 File Offset: 0x0003AFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371320, XrefRangeEnd = 371327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lowChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0003CE3C File Offset: 0x0003B03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371327, XrefRangeEnd = 371331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0003CE8C File Offset: 0x0003B08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0003CEDC File Offset: 0x0003B0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371331, XrefRangeEnd = 371335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteChars(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0003CF48 File Offset: 0x0003B148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371335, XrefRangeEnd = 371336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0003CFB4 File Offset: 0x0003B1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371336, XrefRangeEnd = 371338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteRaw(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0003D004 File Offset: 0x0003B204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371338, XrefRangeEnd = 371339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteBase64(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0003D070 File Offset: 0x0003B270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371339, XrefRangeEnd = 371351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(XmlWriterSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_Init_Private_Void_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0003D0B4 File Offset: 0x0003B2B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 371355, RefRangeEnd = 371362, XrefRangeStart = 371351, XrefRangeEnd = 371355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUtf8RawTextWriterIndent.NativeMethodInfoPtr_WriteIndent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00004E1D File Offset: 0x0000301D
		public XmlUtf8RawTextWriterIndent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0003D0E8 File Offset: 0x0003B2E8
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00004E26 File Offset: 0x00003026
		public unsafe int indentLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentLevel)) = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0003D110 File Offset: 0x0003B310
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00004E41 File Offset: 0x00003041
		public unsafe bool newLineOnAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_newLineOnAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_newLineOnAttributes)) = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0003D138 File Offset: 0x0003B338
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00004E5C File Offset: 0x0000305C
		public unsafe string indentChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_indentChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0003D160 File Offset: 0x0003B360
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00004E7B File Offset: 0x0000307B
		public unsafe bool mixedContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_mixedContent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_mixedContent)) = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0003D188 File Offset: 0x0003B388
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00004E96 File Offset: 0x00003096
		public unsafe BitStack mixedContentStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_mixedContentStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_mixedContentStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0003D1B8 File Offset: 0x0003B3B8
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00004EB5 File Offset: 0x000030B5
		public unsafe ConformanceLevel conformanceLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_conformanceLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUtf8RawTextWriterIndent.NativeFieldInfoPtr_conformanceLevel)) = value;
			}
		}

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr_indentLevel;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr_newLineOnAttributes;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_indentChars;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_mixedContent;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr_mixedContentStack;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeFieldInfoPtr_conformanceLevel;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_XmlWriterSettings_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_WriteDocType_Public_Virtual_Void_String_String_String_String_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Public_Virtual_Void_String_String_String_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_StartElementContent_Internal_Virtual_Void_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_OnRootElement_Internal_Virtual_Void_ConformanceLevel_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Internal_Virtual_Void_String_String_String_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartAttribute_Public_Virtual_Void_String_String_String_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_WriteCData_Public_Virtual_Void_String_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_Void_String_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_WriteProcessingInstruction_Public_Virtual_Void_String_String_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Public_Virtual_Void_String_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Public_Virtual_Void_Char_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Public_Virtual_Void_Char_Char_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_Void_String_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_Virtual_Void_String_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_Void_String_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_WriteBase64_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_XmlWriterSettings_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_WriteIndent_Private_Void_0;
	}
}
