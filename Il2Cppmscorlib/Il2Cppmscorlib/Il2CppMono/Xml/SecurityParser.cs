using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Security;

namespace Il2CppMono.Xml
{
	// Token: 0x0200001B RID: 27
	public class SecurityParser : SmallXmlParser
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00027D90 File Offset: 0x00025F90
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityParser()
		{
			Il2CppClassPointerStore<SecurityParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Xml", "SecurityParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr);
			SecurityParser.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, "root");
			SecurityParser.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, "current");
			SecurityParser.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, "stack");
			SecurityParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663428);
			SecurityParser.NativeMethodInfoPtr_LoadXml_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663429);
			SecurityParser.NativeMethodInfoPtr_ToXml_Public_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663430);
			SecurityParser.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663431);
			SecurityParser.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663432);
			SecurityParser.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663433);
			SecurityParser.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663434);
			SecurityParser.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663435);
			SecurityParser.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663436);
			SecurityParser.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663437);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00027EC4 File Offset: 0x000260C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276091, RefRangeEnd = 1276092, XrefRangeStart = 1276050, XrefRangeEnd = 1276091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00027F00 File Offset: 0x00026100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276092, XrefRangeEnd = 1276099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadXml(string xml)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_LoadXml_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00027F44 File Offset: 0x00026144
		[CallerCount(0)]
		public unsafe SecurityElement ToXml()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_ToXml_Public_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00027F84 File Offset: 0x00026184
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00027FC8 File Offset: 0x000261C8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0002801C File Offset: 0x0002621C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnIgnorableWhitespace(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00028060 File Offset: 0x00026260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276099, XrefRangeEnd = 1276120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000280B4 File Offset: 0x000262B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276120, XrefRangeEnd = 1276128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000280F8 File Offset: 0x000262F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276128, XrefRangeEnd = 1276134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnChars(string ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0002813C File Offset: 0x0002633C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002379 File Offset: 0x00000579
		public SecurityParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00028180 File Offset: 0x00026380
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002382 File Offset: 0x00000582
		public unsafe SecurityElement root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000281B0 File Offset: 0x000263B0
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000023A1 File Offset: 0x000005A1
		public unsafe SecurityElement current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000281E0 File Offset: 0x000263E0
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000023C0 File Offset: 0x000005C0
		public unsafe Stack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_LoadXml_Public_Void_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Public_SecurityElement_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;
	}
}
