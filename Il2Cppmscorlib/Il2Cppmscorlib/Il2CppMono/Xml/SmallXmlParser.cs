using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppMono.Xml
{
	// Token: 0x0200001C RID: 28
	public class SmallXmlParser : Object
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00028210 File Offset: 0x00026410
		// Note: this type is marked as 'beforefieldinit'.
		static SmallXmlParser()
		{
			Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Xml", "SmallXmlParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr);
			SmallXmlParser.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "handler");
			SmallXmlParser.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "reader");
			SmallXmlParser.NativeFieldInfoPtr_elementNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "elementNames");
			SmallXmlParser.NativeFieldInfoPtr_xmlSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "xmlSpaces");
			SmallXmlParser.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "xmlSpace");
			SmallXmlParser.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "buffer");
			SmallXmlParser.NativeFieldInfoPtr_nameBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "nameBuffer");
			SmallXmlParser.NativeFieldInfoPtr_isWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "isWhitespace");
			SmallXmlParser.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "attributes");
			SmallXmlParser.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "line");
			SmallXmlParser.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "column");
			SmallXmlParser.NativeFieldInfoPtr_resetColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "resetColumn");
			SmallXmlParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663438);
			SmallXmlParser.NativeMethodInfoPtr_Error_Private_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663439);
			SmallXmlParser.NativeMethodInfoPtr_UnexpectedEndError_Private_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663440);
			SmallXmlParser.NativeMethodInfoPtr_IsNameChar_Private_Boolean_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663441);
			SmallXmlParser.NativeMethodInfoPtr_IsWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663442);
			SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663443);
			SmallXmlParser.NativeMethodInfoPtr_HandleWhitespaces_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663444);
			SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663445);
			SmallXmlParser.NativeMethodInfoPtr_Peek_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663446);
			SmallXmlParser.NativeMethodInfoPtr_Read_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663447);
			SmallXmlParser.NativeMethodInfoPtr_Expect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663448);
			SmallXmlParser.NativeMethodInfoPtr_ReadUntil_Private_String_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663449);
			SmallXmlParser.NativeMethodInfoPtr_ReadName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663450);
			SmallXmlParser.NativeMethodInfoPtr_Parse_Public_Void_TextReader_IContentHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663451);
			SmallXmlParser.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663452);
			SmallXmlParser.NativeMethodInfoPtr_ReadContent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663453);
			SmallXmlParser.NativeMethodInfoPtr_HandleBufferedContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663454);
			SmallXmlParser.NativeMethodInfoPtr_ReadCharacters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663455);
			SmallXmlParser.NativeMethodInfoPtr_ReadReference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663456);
			SmallXmlParser.NativeMethodInfoPtr_ReadCharacterReference_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663457);
			SmallXmlParser.NativeMethodInfoPtr_ReadAttribute_Private_Void_AttrListImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663458);
			SmallXmlParser.NativeMethodInfoPtr_ReadCDATASection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663459);
			SmallXmlParser.NativeMethodInfoPtr_ReadComment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663460);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000284FC File Offset: 0x000266FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276223, RefRangeEnd = 1276224, XrefRangeStart = 1276187, XrefRangeEnd = 1276223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmallXmlParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00028538 File Offset: 0x00026738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276236, RefRangeEnd = 1276238, XrefRangeStart = 1276224, XrefRangeEnd = 1276236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception Error(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Error_Private_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00028588 File Offset: 0x00026788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276238, XrefRangeEnd = 1276249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception UnexpectedEndError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_UnexpectedEndError_Private_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000285C8 File Offset: 0x000267C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276250, RefRangeEnd = 1276252, XrefRangeStart = 1276249, XrefRangeEnd = 1276250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameChar(char c, bool start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_IsNameChar_Private_Boolean_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00028620 File Offset: 0x00026820
		[CallerCount(0)]
		public unsafe bool IsWhitespace(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_IsWhitespace_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0002866C File Offset: 0x0002686C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276252, XrefRangeEnd = 1276253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhitespaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000286A0 File Offset: 0x000268A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276253, XrefRangeEnd = 1276256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleWhitespaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_HandleWhitespaces_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000286D4 File Offset: 0x000268D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1276258, RefRangeEnd = 1276262, XrefRangeStart = 1276256, XrefRangeEnd = 1276258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhitespaces(bool expected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00028714 File Offset: 0x00026914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Peek_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00028750 File Offset: 0x00026950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276262, RefRangeEnd = 1276264, XrefRangeStart = 1276262, XrefRangeEnd = 1276262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Read_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0002878C File Offset: 0x0002698C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1276265, RefRangeEnd = 1276272, XrefRangeStart = 1276264, XrefRangeEnd = 1276265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Expect(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Expect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000287CC File Offset: 0x000269CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276278, RefRangeEnd = 1276279, XrefRangeStart = 1276272, XrefRangeEnd = 1276278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadUntil(char until, bool handleReferences)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref until;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleReferences;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadUntil_Private_String_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00028820 File Offset: 0x00026A20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1276288, RefRangeEnd = 1276292, XrefRangeStart = 1276279, XrefRangeEnd = 1276288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00028858 File Offset: 0x00026A58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1276307, RefRangeEnd = 1276310, XrefRangeStart = 1276292, XrefRangeEnd = 1276307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(TextReader input, SmallXmlParser.IContentHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Parse_Public_Void_TextReader_IContentHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000288AC File Offset: 0x00026AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276310, XrefRangeEnd = 1276315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000288E0 File Offset: 0x00026AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276348, RefRangeEnd = 1276349, XrefRangeStart = 1276315, XrefRangeEnd = 1276348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadContent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00028914 File Offset: 0x00026B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276355, RefRangeEnd = 1276356, XrefRangeStart = 1276349, XrefRangeEnd = 1276355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBufferedContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_HandleBufferedContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00028948 File Offset: 0x00026B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276356, XrefRangeEnd = 1276363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCharacters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadCharacters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0002897C File Offset: 0x00026B7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1276392, RefRangeEnd = 1276397, XrefRangeStart = 1276363, XrefRangeEnd = 1276392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadReference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000289B0 File Offset: 0x00026BB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276398, RefRangeEnd = 1276400, XrefRangeStart = 1276397, XrefRangeEnd = 1276398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadCharacterReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadCharacterReference_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000289EC File Offset: 0x00026BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276400, XrefRangeEnd = 1276419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAttribute(SmallXmlParser.AttrListImpl a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadAttribute_Private_Void_AttrListImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00028A30 File Offset: 0x00026C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276425, RefRangeEnd = 1276426, XrefRangeStart = 1276419, XrefRangeEnd = 1276425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCDATASection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadCDATASection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00028A64 File Offset: 0x00026C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276426, XrefRangeEnd = 1276431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadComment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000023DF File Offset: 0x000005DF
		public SmallXmlParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00028A98 File Offset: 0x00026C98
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000023E8 File Offset: 0x000005E8
		public unsafe SmallXmlParser.IContentHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmallXmlParser.IContentHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00028AC8 File Offset: 0x00026CC8
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002407 File Offset: 0x00000607
		public unsafe TextReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00028AF8 File Offset: 0x00026CF8
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002426 File Offset: 0x00000626
		public unsafe Stack elementNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_elementNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_elementNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00028B28 File Offset: 0x00026D28
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002445 File Offset: 0x00000645
		public unsafe Stack xmlSpaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00028B58 File Offset: 0x00026D58
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002464 File Offset: 0x00000664
		public unsafe string xmlSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00028B80 File Offset: 0x00026D80
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002483 File Offset: 0x00000683
		public unsafe StringBuilder buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00028BB0 File Offset: 0x00026DB0
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000024A2 File Offset: 0x000006A2
		public unsafe Il2CppStructArray<char> nameBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_nameBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_nameBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00028BE0 File Offset: 0x00026DE0
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000024C1 File Offset: 0x000006C1
		public unsafe bool isWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_isWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_isWhitespace)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00028C08 File Offset: 0x00026E08
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000024DC File Offset: 0x000006DC
		public unsafe SmallXmlParser.AttrListImpl attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmallXmlParser.AttrListImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00028C38 File Offset: 0x00026E38
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000024FB File Offset: 0x000006FB
		public unsafe int line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_line)) = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00028C60 File Offset: 0x00026E60
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002516 File Offset: 0x00000716
		public unsafe int column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_column);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_column)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00028C88 File Offset: 0x00026E88
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002531 File Offset: 0x00000731
		public unsafe bool resetColumn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_resetColumn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_resetColumn)) = value;
			}
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_elementNames;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_xmlSpaces;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_nameBuffer;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_isWhitespace;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_column;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_resetColumn;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_Error_Private_Exception_String_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_UnexpectedEndError_Private_Exception_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_IsNameChar_Private_Boolean_Char_Boolean_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_IsWhitespace_Private_Boolean_Int32_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespaces_Public_Void_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_HandleWhitespaces_Private_Void_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespaces_Public_Void_Boolean_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Private_Int32_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_Read_Private_Int32_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_Expect_Public_Void_Int32_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_ReadUntil_Private_String_Char_Boolean_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_ReadName_Public_String_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Void_TextReader_IContentHandler_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_ReadContent_Public_Void_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_HandleBufferedContent_Private_Void_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_ReadCharacters_Private_Void_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_ReadReference_Private_Void_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_ReadCharacterReference_Private_Int32_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttribute_Private_Void_AttrListImpl_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_ReadCDATASection_Private_Void_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_ReadComment_Private_Void_0;

		// Token: 0x02000565 RID: 1381
		public class IContentHandler : Il2CppObjectBase
		{
			// Token: 0x06005598 RID: 21912 RVA: 0x0018BC78 File Offset: 0x00189E78
			// Note: this type is marked as 'beforefieldinit'.
			static IContentHandler()
			{
				Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "IContentHandler");
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663461);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663462);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartElement_Public_Abstract_Virtual_New_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663463);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndElement_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663464);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663465);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnChars_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663466);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663467);
			}

			// Token: 0x06005599 RID: 21913 RVA: 0x0018BD28 File Offset: 0x00189F28
			[CallerCount(0)]
			public unsafe virtual void OnStartParsing(SmallXmlParser parser)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600559A RID: 21914 RVA: 0x0018BD78 File Offset: 0x00189F78
			[CallerCount(0)]
			public unsafe virtual void OnEndParsing(SmallXmlParser parser)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600559B RID: 21915 RVA: 0x0018BDC8 File Offset: 0x00189FC8
			[CallerCount(0)]
			public unsafe virtual void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartElement_Public_Abstract_Virtual_New_Void_String_IAttrList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600559C RID: 21916 RVA: 0x0018BE28 File Offset: 0x0018A028
			[CallerCount(0)]
			public unsafe virtual void OnEndElement(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndElement_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600559D RID: 21917 RVA: 0x0018BE78 File Offset: 0x0018A078
			[CallerCount(0)]
			public unsafe virtual void OnProcessingInstruction(string name, string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600559E RID: 21918 RVA: 0x0018BED8 File Offset: 0x0018A0D8
			[CallerCount(0)]
			public unsafe virtual void OnChars(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnChars_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600559F RID: 21919 RVA: 0x0018BF28 File Offset: 0x0018A128
			[CallerCount(0)]
			public unsafe virtual void OnIgnorableWhitespace(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055A0 RID: 21920 RVA: 0x0001E663 File Offset: 0x0001C863
			public IContentHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040045C6 RID: 17862
			private static readonly IntPtr NativeMethodInfoPtr_OnStartParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0;

			// Token: 0x040045C7 RID: 17863
			private static readonly IntPtr NativeMethodInfoPtr_OnEndParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0;

			// Token: 0x040045C8 RID: 17864
			private static readonly IntPtr NativeMethodInfoPtr_OnStartElement_Public_Abstract_Virtual_New_Void_String_IAttrList_0;

			// Token: 0x040045C9 RID: 17865
			private static readonly IntPtr NativeMethodInfoPtr_OnEndElement_Public_Abstract_Virtual_New_Void_String_0;

			// Token: 0x040045CA RID: 17866
			private static readonly IntPtr NativeMethodInfoPtr_OnProcessingInstruction_Public_Abstract_Virtual_New_Void_String_String_0;

			// Token: 0x040045CB RID: 17867
			private static readonly IntPtr NativeMethodInfoPtr_OnChars_Public_Abstract_Virtual_New_Void_String_0;

			// Token: 0x040045CC RID: 17868
			private static readonly IntPtr NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Abstract_Virtual_New_Void_String_0;
		}

		// Token: 0x02000566 RID: 1382
		public class IAttrList : Il2CppObjectBase
		{
			// Token: 0x060055A1 RID: 21921 RVA: 0x0018BF78 File Offset: 0x0018A178
			// Note: this type is marked as 'beforefieldinit'.
			static IAttrList()
			{
				Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "IAttrList");
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663468);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663469);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663470);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663471);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663472);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663473);
			}

			// Token: 0x170015E3 RID: 5603
			// (get) Token: 0x060055A2 RID: 21922 RVA: 0x0018C014 File Offset: 0x0018A214
			public unsafe virtual int Length
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055A3 RID: 21923 RVA: 0x0018C05C File Offset: 0x0018A25C
			[CallerCount(0)]
			public unsafe virtual string GetName(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060055A4 RID: 21924 RVA: 0x0018C0AC File Offset: 0x0018A2AC
			[CallerCount(0)]
			public unsafe virtual string GetValue(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060055A5 RID: 21925 RVA: 0x0018C0FC File Offset: 0x0018A2FC
			[CallerCount(0)]
			public unsafe virtual string GetValue(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170015E4 RID: 5604
			// (get) Token: 0x060055A6 RID: 21926 RVA: 0x0018C150 File Offset: 0x0018A350
			public unsafe virtual Il2CppStringArray Names
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x170015E5 RID: 5605
			// (get) Token: 0x060055A7 RID: 21927 RVA: 0x0018C19C File Offset: 0x0018A39C
			public unsafe virtual Il2CppStringArray Values
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x060055A8 RID: 21928 RVA: 0x0001E66C File Offset: 0x0001C86C
			public IAttrList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040045CD RID: 17869
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0;

			// Token: 0x040045CE RID: 17870
			private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Int32_0;

			// Token: 0x040045CF RID: 17871
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_Int32_0;

			// Token: 0x040045D0 RID: 17872
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_String_0;

			// Token: 0x040045D1 RID: 17873
			private static readonly IntPtr NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0;

			// Token: 0x040045D2 RID: 17874
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_Il2CppStringArray_0;
		}

		// Token: 0x02000567 RID: 1383
		public class AttrListImpl : Object
		{
			// Token: 0x060055A9 RID: 21929 RVA: 0x0018C1E8 File Offset: 0x0018A3E8
			// Note: this type is marked as 'beforefieldinit'.
			static AttrListImpl()
			{
				Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "AttrListImpl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr);
				SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, "attrNames");
				SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, "attrValues");
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663474);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663475);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663476);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663477);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Names_Public_Virtual_Final_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663478);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663479);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663480);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Add_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663481);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663482);
			}

			// Token: 0x170015E8 RID: 5608
			// (get) Token: 0x060055AA RID: 21930 RVA: 0x0018C2F0 File Offset: 0x0018A4F0
			public unsafe virtual int Length
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276134, XrefRangeEnd = 1276135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060055AB RID: 21931 RVA: 0x0018C32C File Offset: 0x0018A52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276135, XrefRangeEnd = 1276139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetName(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060055AC RID: 21932 RVA: 0x0018C370 File Offset: 0x0018A570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276139, XrefRangeEnd = 1276143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetValue(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060055AD RID: 21933 RVA: 0x0018C3B4 File Offset: 0x0018A5B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276143, XrefRangeEnd = 1276151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetValue(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170015E9 RID: 5609
			// (get) Token: 0x060055AE RID: 21934 RVA: 0x0018C3FC File Offset: 0x0018A5FC
			public unsafe virtual Il2CppStringArray Names
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276151, XrefRangeEnd = 1276155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Names_Public_Virtual_Final_New_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x170015EA RID: 5610
			// (get) Token: 0x060055AF RID: 21935 RVA: 0x0018C43C File Offset: 0x0018A63C
			public unsafe virtual Il2CppStringArray Values
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276155, XrefRangeEnd = 1276159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x060055B0 RID: 21936 RVA: 0x0018C47C File Offset: 0x0018A67C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1276162, RefRangeEnd = 1276164, XrefRangeStart = 1276159, XrefRangeEnd = 1276162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055B1 RID: 21937 RVA: 0x0018C4B0 File Offset: 0x0018A6B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276164, XrefRangeEnd = 1276174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(string name, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Add_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055B2 RID: 21938 RVA: 0x0018C504 File Offset: 0x0018A704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276174, XrefRangeEnd = 1276187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttrListImpl()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055B3 RID: 21939 RVA: 0x0001E675 File Offset: 0x0001C875
			public AttrListImpl(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015E6 RID: 5606
			// (get) Token: 0x060055B4 RID: 21940 RVA: 0x0018C540 File Offset: 0x0018A740
			// (set) Token: 0x060055B5 RID: 21941 RVA: 0x0001E67E File Offset: 0x0001C87E
			public unsafe List<string> attrNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015E7 RID: 5607
			// (get) Token: 0x060055B6 RID: 21942 RVA: 0x0018C570 File Offset: 0x0018A770
			// (set) Token: 0x060055B7 RID: 21943 RVA: 0x0001E69D File Offset: 0x0001C89D
			public unsafe List<string> attrValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045D3 RID: 17875
			private static readonly IntPtr NativeFieldInfoPtr_attrNames;

			// Token: 0x040045D4 RID: 17876
			private static readonly IntPtr NativeFieldInfoPtr_attrValues;

			// Token: 0x040045D5 RID: 17877
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040045D6 RID: 17878
			private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_Int32_0;

			// Token: 0x040045D7 RID: 17879
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_Int32_0;

			// Token: 0x040045D8 RID: 17880
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_String_0;

			// Token: 0x040045D9 RID: 17881
			private static readonly IntPtr NativeMethodInfoPtr_get_Names_Public_Virtual_Final_New_get_Il2CppStringArray_0;

			// Token: 0x040045DA RID: 17882
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_Il2CppStringArray_0;

			// Token: 0x040045DB RID: 17883
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

			// Token: 0x040045DC RID: 17884
			private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_String_String_0;

			// Token: 0x040045DD RID: 17885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
