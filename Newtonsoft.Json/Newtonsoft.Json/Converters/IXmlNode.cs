using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F5 RID: 245
	public class IXmlNode : Il2CppObjectBase
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x00070968 File Offset: 0x0006EB68
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlNode()
		{
			Il2CppClassPointerStore<IXmlNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "IXmlNode");
			IXmlNode.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667208);
			IXmlNode.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667209);
			IXmlNode.NativeMethodInfoPtr_get_ChildNodes_Public_Abstract_Virtual_New_get_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667210);
			IXmlNode.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_List_1_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667211);
			IXmlNode.NativeMethodInfoPtr_get_ParentNode_Public_Abstract_Virtual_New_get_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667212);
			IXmlNode.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667213);
			IXmlNode.NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667214);
			IXmlNode.NativeMethodInfoPtr_AppendChild_Public_Abstract_Virtual_New_IXmlNode_IXmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667215);
			IXmlNode.NativeMethodInfoPtr_get_NamespaceUri_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667216);
			IXmlNode.NativeMethodInfoPtr_get_WrappedNode_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNode>.NativeClassPtr, 100667217);
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x00070A58 File Offset: 0x0006EC58
		public unsafe virtual XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x00070AA0 File Offset: 0x0006ECA0
		public unsafe virtual string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00070AE4 File Offset: 0x0006ECE4
		public unsafe virtual List<IXmlNode> ChildNodes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_get_ChildNodes_Public_Abstract_Virtual_New_get_List_1_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x00070B30 File Offset: 0x0006ED30
		public unsafe virtual List<IXmlNode> Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_List_1_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IXmlNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00070B7C File Offset: 0x0006ED7C
		public unsafe virtual IXmlNode ParentNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_get_ParentNode_Public_Abstract_Virtual_New_get_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x00070BC8 File Offset: 0x0006EDC8
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x00070C0C File Offset: 0x0006EE0C
		public unsafe virtual string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00070C5C File Offset: 0x0006EE5C
		[CallerCount(0)]
		public unsafe virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_AppendChild_Public_Abstract_Virtual_New_IXmlNode_IXmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x00070CB8 File Offset: 0x0006EEB8
		public unsafe virtual string NamespaceUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_get_NamespaceUri_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x00070CFC File Offset: 0x0006EEFC
		public unsafe virtual Object WrappedNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNode.NativeMethodInfoPtr_get_WrappedNode_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x000083FA File Offset: 0x000065FA
		public IXmlNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildNodes_Public_Abstract_Virtual_New_get_List_1_IXmlNode_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_List_1_IXmlNode_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Abstract_Virtual_New_get_IXmlNode_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_String_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Abstract_Virtual_New_IXmlNode_IXmlNode_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_get_WrappedNode_Public_Abstract_Virtual_New_get_Object_0;
	}
}
