using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Data
{
	// Token: 0x0200007C RID: 124
	public class XMLSchema : Object
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x0003B8EC File Offset: 0x00039AEC
		// Note: this type is marked as 'beforefieldinit'.
		static XMLSchema()
		{
			Il2CppClassPointerStore<XMLSchema>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "XMLSchema");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XMLSchema>.NativeClassPtr);
			XMLSchema.NativeMethodInfoPtr_GetConverter_Internal_Static_TypeConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLSchema>.NativeClassPtr, 100665226);
			XMLSchema.NativeMethodInfoPtr_SetProperties_Internal_Static_Void_Object_XmlAttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLSchema>.NativeClassPtr, 100665227);
			XMLSchema.NativeMethodInfoPtr_FEqualIdentity_Internal_Static_Boolean_XmlNode_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLSchema>.NativeClassPtr, 100665228);
			XMLSchema.NativeMethodInfoPtr_GetBooleanAttribute_Internal_Static_Boolean_XmlElement_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLSchema>.NativeClassPtr, 100665229);
			XMLSchema.NativeMethodInfoPtr_GenUniqueColumnName_Internal_Static_String_String_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLSchema>.NativeClassPtr, 100665230);
			XMLSchema.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLSchema>.NativeClassPtr, 100665231);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0003B994 File Offset: 0x00039B94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908636, RefRangeEnd = 908638, XrefRangeStart = 908632, XrefRangeEnd = 908636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeConverter GetConverter(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLSchema.NativeMethodInfoPtr_GetConverter_Internal_Static_TypeConverter_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0003B9D8 File Offset: 0x00039BD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 908691, RefRangeEnd = 908694, XrefRangeStart = 908638, XrefRangeEnd = 908691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProperties(Object instance, XmlAttributeCollection attrs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLSchema.NativeMethodInfoPtr_SetProperties_Internal_Static_Void_Object_XmlAttributeCollection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0003BA20 File Offset: 0x00039C20
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 908696, RefRangeEnd = 908708, XrefRangeStart = 908694, XrefRangeEnd = 908696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FEqualIdentity(XmlNode node, string name, string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLSchema.NativeMethodInfoPtr_FEqualIdentity_Internal_Static_Boolean_XmlNode_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0003BA88 File Offset: 0x00039C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908720, RefRangeEnd = 908722, XrefRangeStart = 908708, XrefRangeEnd = 908720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrNS);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLSchema.NativeMethodInfoPtr_GetBooleanAttribute_Internal_Static_Boolean_XmlElement_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0003BAFC File Offset: 0x00039CFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908733, RefRangeEnd = 908735, XrefRangeStart = 908722, XrefRangeEnd = 908733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GenUniqueColumnName(string proposedName, DataTable table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(proposedName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLSchema.NativeMethodInfoPtr_GenUniqueColumnName_Internal_Static_String_String_DataTable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0003BB4C File Offset: 0x00039D4C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XMLSchema()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XMLSchema>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLSchema.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0000591F File Offset: 0x00003B1F
		public XMLSchema(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_GetConverter_Internal_Static_TypeConverter_Type_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Internal_Static_Void_Object_XmlAttributeCollection_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_FEqualIdentity_Internal_Static_Boolean_XmlNode_String_String_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_GetBooleanAttribute_Internal_Static_Boolean_XmlElement_String_String_Boolean_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_GenUniqueColumnName_Internal_Static_String_String_DataTable_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
