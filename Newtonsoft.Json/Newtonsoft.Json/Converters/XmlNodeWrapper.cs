using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F0 RID: 240
	public class XmlNodeWrapper : Object
	{
		// Token: 0x0600145F RID: 5215 RVA: 0x0006F868 File Offset: 0x0006DA68
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeWrapper()
		{
			Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XmlNodeWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr);
			XmlNodeWrapper.NativeFieldInfoPtr__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, "_node");
			XmlNodeWrapper.NativeFieldInfoPtr__childNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, "_childNodes");
			XmlNodeWrapper.NativeFieldInfoPtr__attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, "_attributes");
			XmlNodeWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667169);
			XmlNodeWrapper.NativeMethodInfoPtr_get_WrappedNode_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667170);
			XmlNodeWrapper.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_New_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667171);
			XmlNodeWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667172);
			XmlNodeWrapper.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_Final_New_get_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667173);
			XmlNodeWrapper.NativeMethodInfoPtr_get_HasChildNodes_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667174);
			XmlNodeWrapper.NativeMethodInfoPtr_WrapNode_Internal_Static_IXmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667175);
			XmlNodeWrapper.NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667176);
			XmlNodeWrapper.NativeMethodInfoPtr_get_HasAttributes_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667177);
			XmlNodeWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_Final_New_get_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667178);
			XmlNodeWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667179);
			XmlNodeWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667180);
			XmlNodeWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_Final_New_IXmlNode_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667181);
			XmlNodeWrapper.NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr, 100667182);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0006F9EC File Offset: 0x0006DBEC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeWrapper(XmlNode node)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0006FA38 File Offset: 0x0006DC38
		public unsafe virtual Object WrappedNode
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_get_WrappedNode_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0006FA78 File Offset: 0x0006DC78
		public unsafe virtual XmlNodeType NodeType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 367110, RefRangeEnd = 367113, XrefRangeStart = 367110, XrefRangeEnd = 367113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_New_get_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0006FAB4 File Offset: 0x0006DCB4
		public unsafe virtual string LocalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNodeWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0006FAF8 File Offset: 0x0006DCF8
		public unsafe virtual List<IXmlNode> ChildNodes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765152, XrefRangeEnd = 765183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_Final_New_get_List_1_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x0006FB38 File Offset: 0x0006DD38
		public unsafe virtual bool HasChildNodes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNodeWrapper.NativeMethodInfoPtr_get_HasChildNodes_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0006FB80 File Offset: 0x0006DD80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 765204, RefRangeEnd = 765209, XrefRangeStart = 765183, XrefRangeEnd = 765204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IXmlNode WrapNode(XmlNode node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_WrapNode_Internal_Static_IXmlNode_XmlNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0006FBC4 File Offset: 0x0006DDC4
		public unsafe virtual List<IXmlNode> Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765209, XrefRangeEnd = 765244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_List_1_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0006FC04 File Offset: 0x0006DE04
		public unsafe bool HasAttributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765244, XrefRangeEnd = 765247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_get_HasAttributes_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0006FC40 File Offset: 0x0006DE40
		public unsafe virtual IXmlNode ParentNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765247, XrefRangeEnd = 765252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_Final_New_get_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0006FC80 File Offset: 0x0006DE80
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x0006FCB8 File Offset: 0x0006DEB8
		public unsafe virtual string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765252, XrefRangeEnd = 765253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0006FCFC File Offset: 0x0006DEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765253, XrefRangeEnd = 765257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_AppendChild_Public_Virtual_Final_New_IXmlNode_IXmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0006FD4C File Offset: 0x0006DF4C
		public unsafe virtual string NamespaceUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeWrapper.NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00008370 File Offset: 0x00006570
		public XmlNodeWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0006FD84 File Offset: 0x0006DF84
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x00008379 File Offset: 0x00006579
		public unsafe XmlNode _node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeWrapper.NativeFieldInfoPtr__node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeWrapper.NativeFieldInfoPtr__node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0006FDB4 File Offset: 0x0006DFB4
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x00008398 File Offset: 0x00006598
		public unsafe List<IXmlNode> _childNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeWrapper.NativeFieldInfoPtr__childNodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeWrapper.NativeFieldInfoPtr__childNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0006FDE4 File Offset: 0x0006DFE4
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x000083B7 File Offset: 0x000065B7
		public unsafe List<IXmlNode> _attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeWrapper.NativeFieldInfoPtr__attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeWrapper.NativeFieldInfoPtr__attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeFieldInfoPtr__node;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr__childNodes;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr__attributes;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_get_WrappedNode_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_New_get_XmlNodeType_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_New_get_String_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_Final_New_get_List_1_IXmlNode_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChildNodes_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_WrapNode_Internal_Static_IXmlNode_XmlNode_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_List_1_IXmlNode_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAttributes_Private_get_Boolean_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_Final_New_get_IXmlNode_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Virtual_Final_New_IXmlNode_IXmlNode_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_Virtual_Final_New_get_String_0;
	}
}
