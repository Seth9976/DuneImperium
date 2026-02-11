using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000129 RID: 297
	public class XsdSimpleValue : Object
	{
		// Token: 0x060019BB RID: 6587 RVA: 0x00083740 File Offset: 0x00081940
		// Note: this type is marked as 'beforefieldinit'.
		static XsdSimpleValue()
		{
			Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdSimpleValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr);
			XsdSimpleValue.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, "xmlType");
			XsdSimpleValue.NativeFieldInfoPtr_typedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, "typedValue");
			XsdSimpleValue.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaSimpleType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100667245);
			XsdSimpleValue.NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100667246);
			XsdSimpleValue.NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100667247);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000837D4 File Offset: 0x000819D4
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdSimpleValue(XmlSchemaSimpleType st, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdSimpleValue.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaSimpleType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00083834 File Offset: 0x00081A34
		public unsafe XmlSchemaSimpleType XmlType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdSimpleValue.NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00083874 File Offset: 0x00081A74
		public unsafe Object TypedValue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdSimpleValue.NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0000AFA3 File Offset: 0x000091A3
		public XsdSimpleValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x000838B4 File Offset: 0x00081AB4
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0000AFAC File Offset: 0x000091AC
		public unsafe XmlSchemaSimpleType xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_xmlType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_xmlType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x000838E4 File Offset: 0x00081AE4
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0000AFCB File Offset: 0x000091CB
		public unsafe Object typedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_typedValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_typedValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeFieldInfoPtr_typedValue;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaSimpleType_Object_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0;
	}
}
