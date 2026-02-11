using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	public sealed class XName : Object
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00006598 File Offset: 0x00004798
		// Note: this type is marked as 'beforefieldinit'.
		static XName()
		{
			Il2CppClassPointerStore<XName>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XName>.NativeClassPtr);
			XName.NativeFieldInfoPtr__ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XName>.NativeClassPtr, "_ns");
			XName.NativeFieldInfoPtr__localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XName>.NativeClassPtr, "_localName");
			XName.NativeFieldInfoPtr__hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XName>.NativeClassPtr, "_hashCode");
			XName.NativeMethodInfoPtr__ctor_Internal_Void_XNamespace_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663464);
			XName.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663465);
			XName.NativeMethodInfoPtr_get_Namespace_Public_get_XNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663466);
			XName.NativeMethodInfoPtr_get_NamespaceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663467);
			XName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663468);
			XName.NativeMethodInfoPtr_Get_Public_Static_XName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663469);
			XName.NativeMethodInfoPtr_Get_Public_Static_XName_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663470);
			XName.NativeMethodInfoPtr_op_Implicit_Public_Static_XName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663471);
			XName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663472);
			XName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663473);
			XName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XName_XName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663474);
			XName.NativeMethodInfoPtr_System_IEquatable_System_Xml_Linq_XName__Equals_Private_Virtual_Final_New_Boolean_XName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663475);
			XName.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663476);
			XName.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XName>.NativeClassPtr, 100663477);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000671C File Offset: 0x0000491C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238123, XrefRangeEnd = 1238130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XName(XNamespace ns, string localName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr__ctor_Internal_Void_XNamespace_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000677C File Offset: 0x0000497C
		public unsafe string LocalName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000067B4 File Offset: 0x000049B4
		public unsafe XNamespace Namespace
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_get_Namespace_Public_get_XNamespace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr3) : null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000067F4 File Offset: 0x000049F4
		public unsafe string NamespaceName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 399714, RefRangeEnd = 399719, XrefRangeStart = 399714, XrefRangeEnd = 399719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_get_NamespaceName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000682C File Offset: 0x00004A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238130, XrefRangeEnd = 1238135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006864 File Offset: 0x00004A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238138, RefRangeEnd = 1238139, XrefRangeStart = 1238135, XrefRangeEnd = 1238138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XName Get(string expandedName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expandedName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_Get_Public_Static_XName_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XName>(intPtr3) : null;
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000068A8 File Offset: 0x00004AA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238141, RefRangeEnd = 1238143, XrefRangeStart = 1238139, XrefRangeEnd = 1238141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XName Get(string localName, string namespaceName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_Get_Public_Static_XName_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XName>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006900 File Offset: 0x00004B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238144, RefRangeEnd = 1238146, XrefRangeStart = 1238143, XrefRangeEnd = 1238144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator XName(string expandedName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expandedName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_op_Implicit_Public_Static_XName_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XName>(intPtr3) : null;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006944 File Offset: 0x00004B44
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006994 File Offset: 0x00004B94
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000069D0 File Offset: 0x00004BD0
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(XName left, XName right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XName_XName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00006A24 File Offset: 0x00004C24
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IEquatable_System_Xml_Linq_XName__Equals(XName other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_System_IEquatable_System_Xml_Linq_XName__Equals_Private_Virtual_Final_New_Boolean_XName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00006A74 File Offset: 0x00004C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238146, XrefRangeEnd = 1238151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00006AD0 File Offset: 0x00004CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238151, XrefRangeEnd = 1238154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XName.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002478 File Offset: 0x00000678
		public XName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00006B0C File Offset: 0x00004D0C
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002481 File Offset: 0x00000681
		public unsafe XNamespace _ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XName.NativeFieldInfoPtr__ns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XName.NativeFieldInfoPtr__ns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00006B3C File Offset: 0x00004D3C
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000024A0 File Offset: 0x000006A0
		public unsafe string _localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XName.NativeFieldInfoPtr__localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XName.NativeFieldInfoPtr__localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00006B64 File Offset: 0x00004D64
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000024BF File Offset: 0x000006BF
		public unsafe int _hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XName.NativeFieldInfoPtr__hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XName.NativeFieldInfoPtr__hashCode)) = value;
			}
		}

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr__ns;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr__localName;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr__hashCode;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XNamespace_String_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_XNamespace_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceName_Public_get_String_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_XName_String_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_XName_String_String_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_XName_String_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XName_XName_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_System_IEquatable_System_Xml_Linq_XName__Equals_Private_Virtual_Final_New_Boolean_XName_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
