using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CA RID: 202
	public class XmlArrayAttribute : Attribute
	{
		// Token: 0x06001347 RID: 4935 RVA: 0x0006A404 File Offset: 0x00068604
		// Note: this type is marked as 'beforefieldinit'.
		static XmlArrayAttribute()
		{
			Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlArrayAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr);
			XmlArrayAttribute.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, "elementName");
			XmlArrayAttribute.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, "form");
			XmlArrayAttribute.NativeFieldInfoPtr_isNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, "isNullable");
			XmlArrayAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, "ns");
			XmlArrayAttribute.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, "order");
			XmlArrayAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, 100666422);
			XmlArrayAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, 100666423);
			XmlArrayAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, 100666424);
			XmlArrayAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, 100666425);
			XmlArrayAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, 100666426);
			XmlArrayAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayAttribute>.NativeClassPtr, 100666427);
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0006A510 File Offset: 0x00068710
		public unsafe string ElementName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 385186, RefRangeEnd = 385188, XrefRangeStart = 385185, XrefRangeEnd = 385186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0006A548 File Offset: 0x00068748
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0006A584 File Offset: 0x00068784
		public unsafe bool IsNullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x0006A5C0 File Offset: 0x000687C0
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x0006A5F8 File Offset: 0x000687F8
		public unsafe int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0006A634 File Offset: 0x00068834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385188, XrefRangeEnd = 385201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x000082F3 File Offset: 0x000064F3
		public XmlArrayAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x0006A678 File Offset: 0x00068878
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x000082FC File Offset: 0x000064FC
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x0006A6A0 File Offset: 0x000688A0
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x0000831B File Offset: 0x0000651B
		public unsafe XmlSchemaForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_form)) = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x0006A6C8 File Offset: 0x000688C8
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00008336 File Offset: 0x00006536
		public unsafe bool isNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_isNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_isNullable)) = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x0006A6F0 File Offset: 0x000688F0
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00008351 File Offset: 0x00006551
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x0006A718 File Offset: 0x00068918
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00008370 File Offset: 0x00006570
		public unsafe int order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayAttribute.NativeFieldInfoPtr_order)) = value;
			}
		}

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeFieldInfoPtr_isNullable;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeFieldInfoPtr_order;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementName_Public_get_String_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_get_Int32_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}
