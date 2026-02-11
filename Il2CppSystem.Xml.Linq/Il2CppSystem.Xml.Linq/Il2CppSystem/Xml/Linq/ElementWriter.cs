using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000010 RID: 16
	public sealed class ElementWriter : ValueType
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00005F28 File Offset: 0x00004128
		// Note: this type is marked as 'beforefieldinit'.
		static ElementWriter()
		{
			Il2CppClassPointerStore<ElementWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "ElementWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr);
			ElementWriter.NativeFieldInfoPtr__writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, "_writer");
			ElementWriter.NativeFieldInfoPtr__resolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, "_resolver");
			ElementWriter.NativeMethodInfoPtr__ctor_Public_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, 100663450);
			ElementWriter.NativeMethodInfoPtr_WriteElement_Public_Void_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, 100663451);
			ElementWriter.NativeMethodInfoPtr_GetPrefixOfNamespace_Private_String_XNamespace_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, 100663452);
			ElementWriter.NativeMethodInfoPtr_PushAncestors_Private_Void_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, 100663453);
			ElementWriter.NativeMethodInfoPtr_PushElement_Private_Void_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, 100663454);
			ElementWriter.NativeMethodInfoPtr_WriteEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, 100663455);
			ElementWriter.NativeMethodInfoPtr_WriteFullEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, 100663456);
			ElementWriter.NativeMethodInfoPtr_WriteStartElement_Private_Void_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr, 100663457);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006020 File Offset: 0x00004220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238010, XrefRangeEnd = 1238011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementWriter(XmlWriter writer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementWriter.NativeMethodInfoPtr__ctor_Public_Void_XmlWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006070 File Offset: 0x00004270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238025, RefRangeEnd = 1238026, XrefRangeStart = 1238011, XrefRangeEnd = 1238025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteElement(XElement e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementWriter.NativeMethodInfoPtr_WriteElement_Public_Void_XElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000060B8 File Offset: 0x000042B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238033, RefRangeEnd = 1238034, XrefRangeStart = 1238026, XrefRangeEnd = 1238033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDefaultNamespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementWriter.NativeMethodInfoPtr_GetPrefixOfNamespace_Private_String_XNamespace_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006114 File Offset: 0x00004314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238048, RefRangeEnd = 1238049, XrefRangeStart = 1238034, XrefRangeEnd = 1238048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushAncestors(XElement e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementWriter.NativeMethodInfoPtr_PushAncestors_Private_Void_XElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000615C File Offset: 0x0000435C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238059, RefRangeEnd = 1238060, XrefRangeStart = 1238049, XrefRangeEnd = 1238059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushElement(XElement e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementWriter.NativeMethodInfoPtr_PushElement_Private_Void_XElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000061A4 File Offset: 0x000043A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238060, XrefRangeEnd = 1238062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementWriter.NativeMethodInfoPtr_WriteEndElement_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000061DC File Offset: 0x000043DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238062, XrefRangeEnd = 1238064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteFullEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementWriter.NativeMethodInfoPtr_WriteFullEndElement_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006214 File Offset: 0x00004414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238086, RefRangeEnd = 1238087, XrefRangeStart = 1238064, XrefRangeEnd = 1238086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteStartElement(XElement e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementWriter.NativeMethodInfoPtr_WriteStartElement_Private_Void_XElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000239C File Offset: 0x0000059C
		public ElementWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000023A5 File Offset: 0x000005A5
		public ElementWriter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementWriter>.NativeClassPtr))
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000625C File Offset: 0x0000445C
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000023B7 File Offset: 0x000005B7
		public unsafe XmlWriter _writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementWriter.NativeFieldInfoPtr__writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementWriter.NativeFieldInfoPtr__writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000628C File Offset: 0x0000448C
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000023D6 File Offset: 0x000005D6
		public NamespaceResolver _resolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementWriter.NativeFieldInfoPtr__resolver);
				return new NamespaceResolver(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementWriter.NativeFieldInfoPtr__resolver), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NamespaceResolver>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr__writer;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr__resolver;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlWriter_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_WriteElement_Public_Void_XElement_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixOfNamespace_Private_String_XNamespace_Boolean_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_PushAncestors_Private_Void_XElement_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_PushElement_Private_Void_XElement_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndElement_Private_Void_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_WriteFullEndElement_Private_Void_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartElement_Private_Void_XElement_0;
	}
}
