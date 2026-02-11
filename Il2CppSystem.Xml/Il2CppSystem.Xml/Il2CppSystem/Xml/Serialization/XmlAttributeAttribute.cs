using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CD RID: 205
	public class XmlAttributeAttribute : Attribute
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x0006ADC4 File Offset: 0x00068FC4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttributeAttribute()
		{
			Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAttributeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr);
			XmlAttributeAttribute.NativeFieldInfoPtr_attributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, "attributeName");
			XmlAttributeAttribute.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, "dataType");
			XmlAttributeAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, "type");
			XmlAttributeAttribute.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, "form");
			XmlAttributeAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, "ns");
			XmlAttributeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, 100666441);
			XmlAttributeAttribute.NativeMethodInfoPtr_get_AttributeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, 100666442);
			XmlAttributeAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, 100666443);
			XmlAttributeAttribute.NativeMethodInfoPtr_set_DataType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, 100666444);
			XmlAttributeAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, 100666445);
			XmlAttributeAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, 100666446);
			XmlAttributeAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, 100666447);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0006AEE4 File Offset: 0x000690E4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributeAttribute(string attributeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0006AF30 File Offset: 0x00069130
		public unsafe string AttributeName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 385265, RefRangeEnd = 385267, XrefRangeStart = 385264, XrefRangeEnd = 385265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeAttribute.NativeMethodInfoPtr_get_AttributeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x0006AF68 File Offset: 0x00069168
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x0006AFA0 File Offset: 0x000691A0
		public unsafe string DataType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385267, XrefRangeEnd = 385268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeAttribute.NativeMethodInfoPtr_set_DataType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0006AFE4 File Offset: 0x000691E4
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x0006B020 File Offset: 0x00069220
		public unsafe string Namespace
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0006B058 File Offset: 0x00069258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385268, XrefRangeEnd = 385282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00008485 File Offset: 0x00006685
		public XmlAttributeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0006B09C File Offset: 0x0006929C
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x0000848E File Offset: 0x0000668E
		public unsafe string attributeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_attributeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_attributeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0006B0C4 File Offset: 0x000692C4
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x000084AD File Offset: 0x000066AD
		public unsafe string dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_dataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_dataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0006B0EC File Offset: 0x000692EC
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x000084CC File Offset: 0x000066CC
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0006B11C File Offset: 0x0006931C
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x000084EB File Offset: 0x000066EB
		public unsafe XmlSchemaForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_form)) = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0006B144 File Offset: 0x00069344
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x00008506 File Offset: 0x00006706
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeFieldInfoPtr_attributeName;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeName_Public_get_String_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_String_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_set_DataType_Public_set_Void_String_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}
