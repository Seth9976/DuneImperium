using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000049 RID: 73
	public class XmlTextEncoder : Object
	{
		// Token: 0x060005FA RID: 1530 RVA: 0x0002FCAC File Offset: 0x0002DEAC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextEncoder()
		{
			Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextEncoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr);
			XmlTextEncoder.NativeFieldInfoPtr_textWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "textWriter");
			XmlTextEncoder.NativeFieldInfoPtr_inAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "inAttribute");
			XmlTextEncoder.NativeFieldInfoPtr_quoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "quoteChar");
			XmlTextEncoder.NativeFieldInfoPtr_attrValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "attrValue");
			XmlTextEncoder.NativeFieldInfoPtr_cacheAttrValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "cacheAttrValue");
			XmlTextEncoder.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, "xmlCharType");
			XmlTextEncoder.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664224);
			XmlTextEncoder.NativeMethodInfoPtr_set_QuoteChar_Internal_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664225);
			XmlTextEncoder.NativeMethodInfoPtr_StartAttribute_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664226);
			XmlTextEncoder.NativeMethodInfoPtr_EndAttribute_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664227);
			XmlTextEncoder.NativeMethodInfoPtr_get_AttributeValue_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664228);
			XmlTextEncoder.NativeMethodInfoPtr_WriteSurrogateChar_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664229);
			XmlTextEncoder.NativeMethodInfoPtr_Write_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664230);
			XmlTextEncoder.NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664231);
			XmlTextEncoder.NativeMethodInfoPtr_Write_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664232);
			XmlTextEncoder.NativeMethodInfoPtr_WriteRawWithSurrogateChecking_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664233);
			XmlTextEncoder.NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664234);
			XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664235);
			XmlTextEncoder.NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664236);
			XmlTextEncoder.NativeMethodInfoPtr_WriteStringFragment_Private_Void_String_Int32_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664237);
			XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664238);
			XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664239);
			XmlTextEncoder.NativeMethodInfoPtr_WriteEntityRefImpl_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr, 100664240);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0002FEA8 File Offset: 0x0002E0A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 366834, RefRangeEnd = 366837, XrefRangeStart = 366830, XrefRangeEnd = 366834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextEncoder(TextWriter textWriter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextEncoder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
		public unsafe char QuoteChar
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_set_QuoteChar_Internal_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0002FF34 File Offset: 0x0002E134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366843, RefRangeEnd = 366845, XrefRangeStart = 366837, XrefRangeEnd = 366843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAttribute(bool cacheAttrValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cacheAttrValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_StartAttribute_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0002FF74 File Offset: 0x0002E174
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366846, RefRangeEnd = 366848, XrefRangeStart = 366845, XrefRangeEnd = 366846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_EndAttribute_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0002FFA8 File Offset: 0x0002E1A8
		public unsafe string AttributeValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 366850, RefRangeEnd = 366851, XrefRangeStart = 366848, XrefRangeEnd = 366850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_get_AttributeValue_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0002FFE0 File Offset: 0x0002E1E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366859, RefRangeEnd = 366861, XrefRangeStart = 366851, XrefRangeEnd = 366859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSurrogateChar(char lowChar, char highChar)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteSurrogateChar_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0003002C File Offset: 0x0002E22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366895, RefRangeEnd = 366896, XrefRangeStart = 366861, XrefRangeEnd = 366895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(Il2CppStructArray<char> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_Write_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0003008C File Offset: 0x0002E28C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366907, RefRangeEnd = 366908, XrefRangeStart = 366896, XrefRangeEnd = 366907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSurrogateCharEntity(char lowChar, char highChar)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x000300D8 File Offset: 0x0002E2D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 366952, RefRangeEnd = 366956, XrefRangeStart = 366908, XrefRangeEnd = 366952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_Write_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0003011C File Offset: 0x0002E31C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 366965, RefRangeEnd = 366969, XrefRangeStart = 366956, XrefRangeEnd = 366965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRawWithSurrogateChecking(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteRawWithSurrogateChecking_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00030160 File Offset: 0x0002E360
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366996, RefRangeEnd = 366998, XrefRangeStart = 366969, XrefRangeEnd = 366996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRaw(Il2CppStructArray<char> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000301C0 File Offset: 0x0002E3C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367009, RefRangeEnd = 367010, XrefRangeStart = 366998, XrefRangeEnd = 367009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCharEntity(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00030200 File Offset: 0x0002E400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 367015, RefRangeEnd = 367016, XrefRangeStart = 367010, XrefRangeEnd = 367015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEntityRef(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00030244 File Offset: 0x0002E444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367016, XrefRangeEnd = 367018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStringFragment(string str, int offset, int count, Il2CppStructArray<char> helperBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helperBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteStringFragment_Private_Void_String_Int32_Int32_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000302B8 File Offset: 0x0002E4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 367018, XrefRangeEnd = 367023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCharEntityImpl(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000302F8 File Offset: 0x0002E4F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 367026, RefRangeEnd = 367030, XrefRangeStart = 367023, XrefRangeEnd = 367026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCharEntityImpl(string strVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strVal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0003033C File Offset: 0x0002E53C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 367031, RefRangeEnd = 367035, XrefRangeStart = 367030, XrefRangeEnd = 367031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEntityRefImpl(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextEncoder.NativeMethodInfoPtr_WriteEntityRefImpl_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00003ED4 File Offset: 0x000020D4
		public XmlTextEncoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00030380 File Offset: 0x0002E580
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00003EDD File Offset: 0x000020DD
		public unsafe TextWriter textWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_textWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_textWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000303B0 File Offset: 0x0002E5B0
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00003EFC File Offset: 0x000020FC
		public unsafe bool inAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_inAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_inAttribute)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x000303D8 File Offset: 0x0002E5D8
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00003F17 File Offset: 0x00002117
		public unsafe char quoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_quoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_quoteChar)) = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00030400 File Offset: 0x0002E600
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00003F32 File Offset: 0x00002132
		public unsafe StringBuilder attrValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_attrValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_attrValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00030430 File Offset: 0x0002E630
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00003F51 File Offset: 0x00002151
		public unsafe bool cacheAttrValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_cacheAttrValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_cacheAttrValue)) = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00030458 File Offset: 0x0002E658
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00003F6C File Offset: 0x0000216C
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextEncoder.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr_textWriter;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_inAttribute;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_quoteChar;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_attrValue;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_cacheAttrValue;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_set_QuoteChar_Internal_set_Void_Char_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_StartAttribute_Internal_Void_Boolean_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_EndAttribute_Internal_Void_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeValue_Internal_get_String_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateChar_Internal_Void_Char_Char_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_Write_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_WriteSurrogateCharEntity_Internal_Void_Char_Char_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_Write_Internal_Void_String_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_WriteRawWithSurrogateChecking_Internal_Void_String_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntity_Internal_Void_Char_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRef_Internal_Void_String_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringFragment_Private_Void_String_Int32_Int32_Il2CppStructArray_1_Char_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_Char_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharEntityImpl_Private_Void_String_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_WriteEntityRefImpl_Private_Void_String_0;
	}
}
