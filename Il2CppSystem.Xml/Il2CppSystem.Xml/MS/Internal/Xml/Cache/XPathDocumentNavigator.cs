using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000209 RID: 521
	public sealed class XPathDocumentNavigator : XPathNavigator
	{
		// Token: 0x06002DC9 RID: 11721 RVA: 0x000D24A8 File Offset: 0x000D06A8
		// Note: this type is marked as 'beforefieldinit'.
		static XPathDocumentNavigator()
		{
			Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathDocumentNavigator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr);
			XPathDocumentNavigator.NativeFieldInfoPtr__pageCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, "_pageCurrent");
			XPathDocumentNavigator.NativeFieldInfoPtr__pageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, "_pageParent");
			XPathDocumentNavigator.NativeFieldInfoPtr__idxCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, "_idxCurrent");
			XPathDocumentNavigator.NativeFieldInfoPtr__idxParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, "_idxParent");
			XPathDocumentNavigator.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669903);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669904);
			XPathDocumentNavigator.NativeMethodInfoPtr_Clone_Public_Virtual_XPathNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669905);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669906);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669907);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669908);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669909);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669910);
			XPathDocumentNavigator.NativeMethodInfoPtr_MoveToFirstNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669911);
			XPathDocumentNavigator.NativeMethodInfoPtr_MoveToNextNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669912);
			XPathDocumentNavigator.NativeMethodInfoPtr_MoveToParent_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669913);
			XPathDocumentNavigator.NativeMethodInfoPtr_IsSamePosition_Public_Virtual_Boolean_XPathNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669914);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669915);
			XPathDocumentNavigator.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669916);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669917);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669918);
			XPathDocumentNavigator.NativeMethodInfoPtr_GetPositionHashCode_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100669919);
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x000D267C File Offset: 0x000D087C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426561, XrefRangeEnd = 426567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathDocumentNavigator(Il2CppReferenceArray<XPathNode> pageCurrent, int idxCurrent, Il2CppReferenceArray<XPathNode> pageParent, int idxParent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageCurrent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxCurrent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pageParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxParent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000D26F8 File Offset: 0x000D08F8
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426567, XrefRangeEnd = 426583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x000D2730 File Offset: 0x000D0930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426583, XrefRangeEnd = 426592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XPathNavigator Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_Clone_Public_Virtual_XPathNavigator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNavigator>(intPtr3) : null;
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x000D2770 File Offset: 0x000D0970
		public unsafe override XPathNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XPathNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x000D27AC File Offset: 0x000D09AC
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x000D27E4 File Offset: 0x000D09E4
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x000D281C File Offset: 0x000D0A1C
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000D2854 File Offset: 0x000D0A54
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x000D2894 File Offset: 0x000D0A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426592, XrefRangeEnd = 426604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceScope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_MoveToFirstNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x000D28E0 File Offset: 0x000D0AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426604, XrefRangeEnd = 426611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToNextNamespace(XPathNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_MoveToNextNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x000D292C File Offset: 0x000D0B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426611, XrefRangeEnd = 426612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_MoveToParent_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000D2968 File Offset: 0x000D0B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426612, XrefRangeEnd = 426614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsSamePosition(XPathNavigator other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_IsSamePosition_Public_Virtual_Boolean_XPathNavigator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x000D29B8 File Offset: 0x000D0BB8
		public unsafe override Object UnderlyingObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x000D29F8 File Offset: 0x000D0BF8
		[CallerCount(0)]
		public unsafe bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x000D2A34 File Offset: 0x000D0C34
		public unsafe int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x000D2A70 File Offset: 0x000D0C70
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000D2AAC File Offset: 0x000D0CAC
		[CallerCount(0)]
		public unsafe int GetPositionHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_GetPositionHashCode_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00012E25 File Offset: 0x00011025
		public XPathDocumentNavigator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x000D2AE8 File Offset: 0x000D0CE8
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x00012E2E File Offset: 0x0001102E
		public unsafe Il2CppReferenceArray<XPathNode> _pageCurrent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr__pageCurrent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr__pageCurrent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x000D2B18 File Offset: 0x000D0D18
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x00012E4D File Offset: 0x0001104D
		public unsafe Il2CppReferenceArray<XPathNode> _pageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr__pageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr__pageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06002DE0 RID: 11744 RVA: 0x000D2B48 File Offset: 0x000D0D48
		// (set) Token: 0x06002DE1 RID: 11745 RVA: 0x00012E6C File Offset: 0x0001106C
		public unsafe int _idxCurrent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr__idxCurrent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr__idxCurrent)) = value;
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x000D2B70 File Offset: 0x000D0D70
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x00012E87 File Offset: 0x00011087
		public unsafe int _idxParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr__idxParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr__idxParent)) = value;
			}
		}

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeFieldInfoPtr__pageCurrent;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeFieldInfoPtr__pageParent;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeFieldInfoPtr__idxCurrent;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeFieldInfoPtr__idxParent;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_XPathNavigator_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XPathNodeType_0;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeMethodInfoPtr_MoveToParent_Public_Virtual_Boolean_0;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeMethodInfoPtr_IsSamePosition_Public_Virtual_Boolean_XPathNavigator_0;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_get_Object_0;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionHashCode_Public_Int32_0;
	}
}
