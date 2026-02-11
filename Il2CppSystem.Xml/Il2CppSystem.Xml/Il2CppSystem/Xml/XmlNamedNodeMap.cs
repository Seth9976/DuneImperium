using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000072 RID: 114
	public class XmlNamedNodeMap : Object
	{
		// Token: 0x06000DCB RID: 3531 RVA: 0x0005204C File Offset: 0x0005024C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNamedNodeMap()
		{
			Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNamedNodeMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr);
			XmlNamedNodeMap.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, "parent");
			XmlNamedNodeMap.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, "nodes");
			XmlNamedNodeMap.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665544);
			XmlNamedNodeMap.NativeMethodInfoPtr_GetNamedItem_Public_Virtual_New_XmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665545);
			XmlNamedNodeMap.NativeMethodInfoPtr_SetNamedItem_Public_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665546);
			XmlNamedNodeMap.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665547);
			XmlNamedNodeMap.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665548);
			XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665549);
			XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665550);
			XmlNamedNodeMap.NativeMethodInfoPtr_AddNode_Internal_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665551);
			XmlNamedNodeMap.NativeMethodInfoPtr_AddNodeForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665552);
			XmlNamedNodeMap.NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_New_XmlNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665553);
			XmlNamedNodeMap.NativeMethodInfoPtr_ReplaceNodeAt_Internal_XmlNode_Int32_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665554);
			XmlNamedNodeMap.NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_New_XmlNode_Int32_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665555);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00052194 File Offset: 0x00050394
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamedNodeMap(XmlNode parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000521E0 File Offset: 0x000503E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375326, XrefRangeEnd = 375331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode GetNamedItem(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_GetNamedItem_Public_Virtual_New_XmlNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0005223C File Offset: 0x0005043C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375331, XrefRangeEnd = 375336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode SetNamedItem(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_SetNamedItem_Public_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00052298 File Offset: 0x00050498
		public unsafe virtual int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375337, RefRangeEnd = 375338, XrefRangeStart = 375336, XrefRangeEnd = 375337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000522E0 File Offset: 0x000504E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375338, XrefRangeEnd = 375339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0005232C File Offset: 0x0005052C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375339, XrefRangeEnd = 375343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNodeOffset(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0005237C File Offset: 0x0005057C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 375348, RefRangeEnd = 375351, XrefRangeStart = 375343, XrefRangeEnd = 375348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNodeOffset(string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000523DC File Offset: 0x000505DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375355, RefRangeEnd = 375357, XrefRangeStart = 375351, XrefRangeEnd = 375355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AddNode(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_AddNode_Internal_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00052438 File Offset: 0x00050638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375359, RefRangeEnd = 375360, XrefRangeStart = 375357, XrefRangeEnd = 375359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_AddNodeForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000524A8 File Offset: 0x000506A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 375364, RefRangeEnd = 375368, XrefRangeStart = 375360, XrefRangeEnd = 375364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode RemoveNodeAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_New_XmlNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00052500 File Offset: 0x00050700
		[CallerCount(0)]
		public unsafe XmlNode ReplaceNodeAt(int i, XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr_ReplaceNodeAt_Internal_XmlNode_Int32_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00052560 File Offset: 0x00050760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375372, RefRangeEnd = 375373, XrefRangeStart = 375368, XrefRangeEnd = 375372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode InsertNodeAt(int i, XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_New_XmlNode_Int32_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00006998 File Offset: 0x00004B98
		public XmlNamedNodeMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x000525CC File Offset: 0x000507CC
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x000069A1 File Offset: 0x00004BA1
		public unsafe XmlNode parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x000525FC File Offset: 0x000507FC
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x000069C0 File Offset: 0x00004BC0
		public XmlNamedNodeMap.SmallXmlNodeList nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_nodes);
				return new XmlNamedNodeMap.SmallXmlNodeList(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_nodes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_nodes;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_GetNamedItem_Public_Virtual_New_XmlNode_String_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_SetNamedItem_Public_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_String_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Internal_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_AddNodeForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_New_XmlNode_Int32_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceNodeAt_Internal_XmlNode_Int32_XmlNode_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_New_XmlNode_Int32_XmlNode_0;

		// Token: 0x0200023C RID: 572
		public sealed class SmallXmlNodeList : ValueType
		{
			// Token: 0x0600305E RID: 12382 RVA: 0x000DA220 File Offset: 0x000D8420
			// Note: this type is marked as 'beforefieldinit'.
			static SmallXmlNodeList()
			{
				Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, "SmallXmlNodeList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr);
				XmlNamedNodeMap.SmallXmlNodeList.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, "field");
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665556);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665557);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Add_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665558);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665559);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Insert_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665560);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665561);
			}

			// Token: 0x17001048 RID: 4168
			// (get) Token: 0x0600305F RID: 12383 RVA: 0x000DA2D8 File Offset: 0x000D84D8
			public unsafe int Count
			{
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 375235, RefRangeEnd = 375244, XrefRangeStart = 375232, XrefRangeEnd = 375235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001049 RID: 4169
			public unsafe Object this[int index]
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 375247, RefRangeEnd = 375261, XrefRangeStart = 375244, XrefRangeEnd = 375247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
			}

			// Token: 0x06003061 RID: 12385 RVA: 0x000DA370 File Offset: 0x000D8570
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 375272, RefRangeEnd = 375275, XrefRangeStart = 375261, XrefRangeEnd = 375272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Add_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003062 RID: 12386 RVA: 0x000DA3B8 File Offset: 0x000D85B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375291, RefRangeEnd = 375292, XrefRangeStart = 375275, XrefRangeEnd = 375291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003063 RID: 12387 RVA: 0x000DA3FC File Offset: 0x000D85FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375315, RefRangeEnd = 375316, XrefRangeStart = 375292, XrefRangeEnd = 375315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Insert(int index, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Insert_Public_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003064 RID: 12388 RVA: 0x000DA454 File Offset: 0x000D8654
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375325, RefRangeEnd = 375326, XrefRangeStart = 375316, XrefRangeEnd = 375325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003065 RID: 12389 RVA: 0x00014415 File Offset: 0x00012615
			public SmallXmlNodeList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003066 RID: 12390 RVA: 0x0001441E File Offset: 0x0001261E
			public SmallXmlNodeList()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr))
			{
			}

			// Token: 0x17001047 RID: 4167
			// (get) Token: 0x06003067 RID: 12391 RVA: 0x000DA498 File Offset: 0x000D8698
			// (set) Token: 0x06003068 RID: 12392 RVA: 0x00014430 File Offset: 0x00012630
			public unsafe Object field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.NativeFieldInfoPtr_field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002555 RID: 9557
			private static readonly IntPtr NativeFieldInfoPtr_field;

			// Token: 0x04002556 RID: 9558
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x04002557 RID: 9559
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0;

			// Token: 0x04002558 RID: 9560
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_0;

			// Token: 0x04002559 RID: 9561
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

			// Token: 0x0400255A RID: 9562
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_Object_0;

			// Token: 0x0400255B RID: 9563
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

			// Token: 0x0200029D RID: 669
			public class SingleObjectEnumerator : Object
			{
				// Token: 0x06003323 RID: 13091 RVA: 0x000E135C File Offset: 0x000DF55C
				// Note: this type is marked as 'beforefieldinit'.
				static SingleObjectEnumerator()
				{
					Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, "SingleObjectEnumerator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_loneValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, "loneValue");
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, "position");
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100665562);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100665563);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100665564);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100665565);
				}

				// Token: 0x06003324 RID: 13092 RVA: 0x000E1400 File Offset: 0x000DF600
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375230, XrefRangeEnd = 375232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SingleObjectEnumerator(Object value)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x17001124 RID: 4388
				// (get) Token: 0x06003325 RID: 13093 RVA: 0x000E144C File Offset: 0x000DF64C
				public unsafe virtual Object Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06003326 RID: 13094 RVA: 0x000E148C File Offset: 0x000DF68C
				[CallerCount(0)]
				public unsafe virtual bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06003327 RID: 13095 RVA: 0x000E14C8 File Offset: 0x000DF6C8
				[CallerCount(0)]
				public unsafe virtual void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003328 RID: 13096 RVA: 0x0001627D File Offset: 0x0001447D
				public SingleObjectEnumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001122 RID: 4386
				// (get) Token: 0x06003329 RID: 13097 RVA: 0x000E14FC File Offset: 0x000DF6FC
				// (set) Token: 0x0600332A RID: 13098 RVA: 0x00016286 File Offset: 0x00014486
				public unsafe Object loneValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_loneValue);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_loneValue), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001123 RID: 4387
				// (get) Token: 0x0600332B RID: 13099 RVA: 0x000E152C File Offset: 0x000DF72C
				// (set) Token: 0x0600332C RID: 13100 RVA: 0x000162A5 File Offset: 0x000144A5
				public unsafe int position
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_position);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_position)) = value;
					}
				}

				// Token: 0x04002866 RID: 10342
				private static readonly IntPtr NativeFieldInfoPtr_loneValue;

				// Token: 0x04002867 RID: 10343
				private static readonly IntPtr NativeFieldInfoPtr_position;

				// Token: 0x04002868 RID: 10344
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

				// Token: 0x04002869 RID: 10345
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

				// Token: 0x0400286A RID: 10346
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x0400286B RID: 10347
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
			}
		}
	}
}
