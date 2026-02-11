using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CF RID: 207
	public class XmlAttributes : Object
	{
		// Token: 0x06001396 RID: 5014 RVA: 0x0006B3DC File Offset: 0x000695DC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttributes()
		{
			Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr);
			XmlAttributes.NativeFieldInfoPtr_xmlAnyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlAnyAttribute");
			XmlAttributes.NativeFieldInfoPtr_xmlAnyElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlAnyElements");
			XmlAttributes.NativeFieldInfoPtr_xmlArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlArray");
			XmlAttributes.NativeFieldInfoPtr_xmlArrayItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlArrayItems");
			XmlAttributes.NativeFieldInfoPtr_xmlAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlAttribute");
			XmlAttributes.NativeFieldInfoPtr_xmlChoiceIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlChoiceIdentifier");
			XmlAttributes.NativeFieldInfoPtr_xmlDefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlDefaultValue");
			XmlAttributes.NativeFieldInfoPtr_xmlElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlElements");
			XmlAttributes.NativeFieldInfoPtr_xmlEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlEnum");
			XmlAttributes.NativeFieldInfoPtr_xmlIgnore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlIgnore");
			XmlAttributes.NativeFieldInfoPtr_xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlns");
			XmlAttributes.NativeFieldInfoPtr_xmlRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlRoot");
			XmlAttributes.NativeFieldInfoPtr_xmlText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlText");
			XmlAttributes.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, "xmlType");
			XmlAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666453);
			XmlAttributes.NativeMethodInfoPtr__ctor_Public_Void_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666454);
			XmlAttributes.NativeMethodInfoPtr_get_XmlAnyAttribute_Public_get_XmlAnyAttributeAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666455);
			XmlAttributes.NativeMethodInfoPtr_get_XmlAnyElements_Public_get_XmlAnyElementAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666456);
			XmlAttributes.NativeMethodInfoPtr_get_XmlArray_Public_get_XmlArrayAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666457);
			XmlAttributes.NativeMethodInfoPtr_get_XmlArrayItems_Public_get_XmlArrayItemAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666458);
			XmlAttributes.NativeMethodInfoPtr_get_XmlAttribute_Public_get_XmlAttributeAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666459);
			XmlAttributes.NativeMethodInfoPtr_get_XmlChoiceIdentifier_Public_get_XmlChoiceIdentifierAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666460);
			XmlAttributes.NativeMethodInfoPtr_get_XmlDefaultValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666461);
			XmlAttributes.NativeMethodInfoPtr_get_XmlElements_Public_get_XmlElementAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666462);
			XmlAttributes.NativeMethodInfoPtr_get_XmlIgnore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666463);
			XmlAttributes.NativeMethodInfoPtr_get_Xmlns_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666464);
			XmlAttributes.NativeMethodInfoPtr_get_XmlRoot_Public_get_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666465);
			XmlAttributes.NativeMethodInfoPtr_get_XmlText_Public_get_XmlTextAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666466);
			XmlAttributes.NativeMethodInfoPtr_get_XmlType_Public_get_XmlTypeAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666467);
			XmlAttributes.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666468);
			XmlAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666469);
			XmlAttributes.NativeMethodInfoPtr_get_SortableOrder_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr, 100666470);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0006B68C File Offset: 0x0006988C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 385368, RefRangeEnd = 385375, XrefRangeStart = 385347, XrefRangeEnd = 385368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0006B6C8 File Offset: 0x000698C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 385474, RefRangeEnd = 385478, XrefRangeStart = 385375, XrefRangeEnd = 385474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributes(ICustomAttributeProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr__ctor_Public_Void_ICustomAttributeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x0006B714 File Offset: 0x00069914
		public unsafe XmlAnyAttributeAttribute XmlAnyAttribute
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlAnyAttribute_Public_get_XmlAnyAttributeAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAnyAttributeAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0006B754 File Offset: 0x00069954
		public unsafe XmlAnyElementAttributes XmlAnyElements
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlAnyElements_Public_get_XmlAnyElementAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAnyElementAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0006B794 File Offset: 0x00069994
		public unsafe XmlArrayAttribute XmlArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlArray_Public_get_XmlArrayAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlArrayAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0006B7D4 File Offset: 0x000699D4
		public unsafe XmlArrayItemAttributes XmlArrayItems
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlArrayItems_Public_get_XmlArrayItemAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlArrayItemAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x0006B814 File Offset: 0x00069A14
		public unsafe XmlAttributeAttribute XmlAttribute
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlAttribute_Public_get_XmlAttributeAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributeAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0006B854 File Offset: 0x00069A54
		public unsafe XmlChoiceIdentifierAttribute XmlChoiceIdentifier
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlChoiceIdentifier_Public_get_XmlChoiceIdentifierAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlChoiceIdentifierAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x0006B894 File Offset: 0x00069A94
		public unsafe Object XmlDefaultValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlDefaultValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0006B8D4 File Offset: 0x00069AD4
		public unsafe XmlElementAttributes XmlElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlElements_Public_get_XmlElementAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElementAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0006B914 File Offset: 0x00069B14
		public unsafe bool XmlIgnore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlIgnore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0006B950 File Offset: 0x00069B50
		public unsafe bool Xmlns
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_Xmlns_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0006B98C File Offset: 0x00069B8C
		public unsafe XmlRootAttribute XmlRoot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlRoot_Public_get_XmlRootAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlRootAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x0006B9CC File Offset: 0x00069BCC
		public unsafe XmlTextAttribute XmlText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlText_Public_get_XmlTextAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x0006BA0C File Offset: 0x00069C0C
		public unsafe XmlTypeAttribute XmlType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_XmlType_Public_get_XmlTypeAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0006BA4C File Offset: 0x00069C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385556, RefRangeEnd = 385557, XrefRangeStart = 385478, XrefRangeEnd = 385556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x0006BA90 File Offset: 0x00069C90
		public unsafe Nullable<int> Order
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 385566, RefRangeEnd = 385569, XrefRangeStart = 385557, XrefRangeEnd = 385566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0006BAC8 File Offset: 0x00069CC8
		public unsafe int SortableOrder
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 385575, RefRangeEnd = 385577, XrefRangeStart = 385569, XrefRangeEnd = 385575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributes.NativeMethodInfoPtr_get_SortableOrder_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0000854D File Offset: 0x0000674D
		public XmlAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0006BB04 File Offset: 0x00069D04
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x00008556 File Offset: 0x00006756
		public unsafe XmlAnyAttributeAttribute xmlAnyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAnyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAnyAttributeAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAnyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0006BB34 File Offset: 0x00069D34
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x00008575 File Offset: 0x00006775
		public unsafe XmlAnyElementAttributes xmlAnyElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAnyElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAnyElementAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAnyElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0006BB64 File Offset: 0x00069D64
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x00008594 File Offset: 0x00006794
		public unsafe XmlArrayAttribute xmlArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlArrayAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0006BB94 File Offset: 0x00069D94
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x000085B3 File Offset: 0x000067B3
		public unsafe XmlArrayItemAttributes xmlArrayItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlArrayItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlArrayItemAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlArrayItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0006BBC4 File Offset: 0x00069DC4
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x000085D2 File Offset: 0x000067D2
		public unsafe XmlAttributeAttribute xmlAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAttributeAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0006BBF4 File Offset: 0x00069DF4
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x000085F1 File Offset: 0x000067F1
		public unsafe XmlChoiceIdentifierAttribute xmlChoiceIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlChoiceIdentifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlChoiceIdentifierAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlChoiceIdentifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0006BC24 File Offset: 0x00069E24
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x00008610 File Offset: 0x00006810
		public unsafe Object xmlDefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlDefaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlDefaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0006BC54 File Offset: 0x00069E54
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x0000862F File Offset: 0x0000682F
		public unsafe XmlElementAttributes xmlElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlElementAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x0006BC84 File Offset: 0x00069E84
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x0000864E File Offset: 0x0000684E
		public unsafe XmlEnumAttribute xmlEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlEnum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlEnumAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0006BCB4 File Offset: 0x00069EB4
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x0000866D File Offset: 0x0000686D
		public unsafe bool xmlIgnore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlIgnore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlIgnore)) = value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0006BCDC File Offset: 0x00069EDC
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x00008688 File Offset: 0x00006888
		public unsafe bool xmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlns)) = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x0006BD04 File Offset: 0x00069F04
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x000086A3 File Offset: 0x000068A3
		public unsafe XmlRootAttribute xmlRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlRootAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0006BD34 File Offset: 0x00069F34
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x000086C2 File Offset: 0x000068C2
		public unsafe XmlTextAttribute xmlText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0006BD64 File Offset: 0x00069F64
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x000086E1 File Offset: 0x000068E1
		public unsafe XmlTypeAttribute xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributes.NativeFieldInfoPtr_xmlType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeFieldInfoPtr_xmlAnyAttribute;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeFieldInfoPtr_xmlAnyElements;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeFieldInfoPtr_xmlArray;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeFieldInfoPtr_xmlArrayItems;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeFieldInfoPtr_xmlAttribute;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeFieldInfoPtr_xmlChoiceIdentifier;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeFieldInfoPtr_xmlDefaultValue;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeFieldInfoPtr_xmlElements;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeFieldInfoPtr_xmlEnum;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeFieldInfoPtr_xmlIgnore;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeFieldInfoPtr_xmlns;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr_xmlRoot;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeFieldInfoPtr_xmlText;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICustomAttributeProvider_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlAnyAttribute_Public_get_XmlAnyAttributeAttribute_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlAnyElements_Public_get_XmlAnyElementAttributes_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlArray_Public_get_XmlArrayAttribute_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlArrayItems_Public_get_XmlArrayItemAttributes_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlAttribute_Public_get_XmlAttributeAttribute_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlChoiceIdentifier_Public_get_XmlChoiceIdentifierAttribute_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlDefaultValue_Public_get_Object_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlElements_Public_get_XmlElementAttributes_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlIgnore_Public_get_Boolean_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_get_Xmlns_Public_get_Boolean_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlRoot_Public_get_XmlRootAttribute_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlText_Public_get_XmlTextAttribute_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_get_XmlTypeAttribute_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Internal_get_Nullable_1_Int32_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_get_SortableOrder_Internal_get_Int32_0;
	}
}
