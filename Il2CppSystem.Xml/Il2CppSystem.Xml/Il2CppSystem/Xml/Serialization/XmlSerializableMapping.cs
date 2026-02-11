using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000FB RID: 251
	public class XmlSerializableMapping : XmlTypeMapping
	{
		// Token: 0x060016C5 RID: 5829 RVA: 0x00078200 File Offset: 0x00076400
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializableMapping()
		{
			Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializableMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr);
			XmlSerializableMapping.NativeFieldInfoPtr__schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr, "_schema");
			XmlSerializableMapping.NativeFieldInfoPtr__schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr, "_schemaType");
			XmlSerializableMapping.NativeFieldInfoPtr__schemaTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr, "_schemaTypeName");
			XmlSerializableMapping.NativeMethodInfoPtr__ctor_Internal_Void_XmlRootAttribute_String_String_TypeData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr, 100666900);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00078280 File Offset: 0x00076480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390028, RefRangeEnd = 390029, XrefRangeStart = 389936, XrefRangeEnd = 390028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializableMapping(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlTypeNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializableMapping.NativeMethodInfoPtr__ctor_Internal_Void_XmlRootAttribute_String_String_TypeData_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00009AA8 File Offset: 0x00007CA8
		public XmlSerializableMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x00078328 File Offset: 0x00076528
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00009AB1 File Offset: 0x00007CB1
		public unsafe XmlSchema _schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x00078358 File Offset: 0x00076558
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x00009AD0 File Offset: 0x00007CD0
		public unsafe XmlSchemaComplexType _schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x00078388 File Offset: 0x00076588
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x00009AEF File Offset: 0x00007CEF
		public unsafe XmlQualifiedName _schemaTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schemaTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schemaTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeFieldInfoPtr__schema;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeFieldInfoPtr__schemaType;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeFieldInfoPtr__schemaTypeName;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlRootAttribute_String_String_TypeData_String_String_0;
	}
}
