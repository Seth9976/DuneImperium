using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D1 RID: 209
	public class XmlCustomFormatter : Object
	{
		// Token: 0x060013CC RID: 5068 RVA: 0x0006BEA4 File Offset: 0x0006A0A4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCustomFormatter()
		{
			Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlCustomFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr);
			XmlCustomFormatter.NativeFieldInfoPtr_allTimeFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, "allTimeFormats");
			XmlCustomFormatter.NativeMethodInfoPtr_FromEnum_Internal_Static_String_Int64_Il2CppStringArray_Il2CppStructArray_1_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100666473);
			XmlCustomFormatter.NativeMethodInfoPtr_FromXmlName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100666474);
			XmlCustomFormatter.NativeMethodInfoPtr_FromXmlNCName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100666475);
			XmlCustomFormatter.NativeMethodInfoPtr_ToXmlString_Internal_Static_String_TypeData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100666476);
			XmlCustomFormatter.NativeMethodInfoPtr_FromXmlString_Internal_Static_Object_TypeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCustomFormatter>.NativeClassPtr, 100666477);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0006BF4C File Offset: 0x0006A14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385584, XrefRangeEnd = 385616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FromEnum(long value, Il2CppStringArray values, Il2CppStructArray<long> ids, string typeName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ids);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCustomFormatter.NativeMethodInfoPtr_FromEnum_Internal_Static_String_Int64_Il2CppStringArray_Il2CppStructArray_1_Int64_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0006BFBC File Offset: 0x0006A1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385616, XrefRangeEnd = 385620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FromXmlName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCustomFormatter.NativeMethodInfoPtr_FromXmlName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0006BFF8 File Offset: 0x0006A1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385620, XrefRangeEnd = 385624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FromXmlNCName(string ncName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ncName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCustomFormatter.NativeMethodInfoPtr_FromXmlNCName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0006C034 File Offset: 0x0006A234
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 385676, RefRangeEnd = 385680, XrefRangeStart = 385624, XrefRangeEnd = 385676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToXmlString(TypeData type, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCustomFormatter.NativeMethodInfoPtr_ToXmlString_Internal_Static_String_TypeData_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0006C084 File Offset: 0x0006A284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 385739, RefRangeEnd = 385741, XrefRangeStart = 385680, XrefRangeEnd = 385739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FromXmlString(TypeData type, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCustomFormatter.NativeMethodInfoPtr_FromXmlString_Internal_Static_Object_TypeData_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x00008728 File Offset: 0x00006928
		public XmlCustomFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0006C0DC File Offset: 0x0006A2DC
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x00008731 File Offset: 0x00006931
		public unsafe static Il2CppStringArray allTimeFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlCustomFormatter.NativeFieldInfoPtr_allTimeFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlCustomFormatter.NativeFieldInfoPtr_allTimeFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeFieldInfoPtr_allTimeFormats;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_FromEnum_Internal_Static_String_Int64_Il2CppStringArray_Il2CppStructArray_1_Int64_String_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlName_Internal_Static_String_String_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlNCName_Internal_Static_String_String_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Internal_Static_String_TypeData_Object_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlString_Internal_Static_Object_TypeData_String_0;
	}
}
