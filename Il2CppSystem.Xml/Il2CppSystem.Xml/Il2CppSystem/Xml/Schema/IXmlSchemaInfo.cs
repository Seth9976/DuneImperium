using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000178 RID: 376
	public class IXmlSchemaInfo : Il2CppObjectBase
	{
		// Token: 0x06001D90 RID: 7568 RVA: 0x00092E30 File Offset: 0x00091030
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlSchemaInfo()
		{
			Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "IXmlSchemaInfo");
			IXmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Abstract_Virtual_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667770);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667771);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667772);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667773);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Abstract_Virtual_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667774);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Abstract_Virtual_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667775);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Abstract_Virtual_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667776);
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x00092EE4 File Offset: 0x000910E4
		public unsafe virtual XmlSchemaValidity Validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Abstract_Virtual_New_get_XmlSchemaValidity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00092F2C File Offset: 0x0009112C
		public unsafe virtual bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00092F74 File Offset: 0x00091174
		public unsafe virtual bool IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00092FBC File Offset: 0x000911BC
		public unsafe virtual XmlSchemaSimpleType MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_XmlSchemaSimpleType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00093008 File Offset: 0x00091208
		public unsafe virtual XmlSchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Abstract_Virtual_New_get_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x00093054 File Offset: 0x00091254
		public unsafe virtual XmlSchemaElement SchemaElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Abstract_Virtual_New_get_XmlSchemaElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x000930A0 File Offset: 0x000912A0
		public unsafe virtual XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Abstract_Virtual_New_get_XmlSchemaAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0000C201 File Offset: 0x0000A401
		public IXmlSchemaInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Abstract_Virtual_New_get_XmlSchemaValidity_0;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_XmlSchemaSimpleType_0;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Abstract_Virtual_New_get_XmlSchemaType_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Abstract_Virtual_New_get_XmlSchemaElement_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Abstract_Virtual_New_get_XmlSchemaAttribute_0;
	}
}
