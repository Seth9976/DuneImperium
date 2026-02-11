using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001F RID: 31
	public class IDtdInfo : Il2CppObjectBase
	{
		// Token: 0x0600025E RID: 606 RVA: 0x0001EED0 File Offset: 0x0001D0D0
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdInfo()
		{
			Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdInfo");
			IDtdInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663605);
			IDtdInfo.NativeMethodInfoPtr_get_InternalDtdSubset_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663606);
			IDtdInfo.NativeMethodInfoPtr_get_HasDefaultAttributes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663607);
			IDtdInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663608);
			IDtdInfo.NativeMethodInfoPtr_LookupAttributeList_Public_Abstract_Virtual_New_IDtdAttributeListInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663609);
			IDtdInfo.NativeMethodInfoPtr_LookupEntity_Public_Abstract_Virtual_New_IDtdEntityInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663610);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0001EF70 File Offset: 0x0001D170
		public unsafe virtual XmlQualifiedName Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_XmlQualifiedName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0001EFBC File Offset: 0x0001D1BC
		public unsafe virtual string InternalDtdSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_InternalDtdSubset_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0001F000 File Offset: 0x0001D200
		public unsafe virtual bool HasDefaultAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_HasDefaultAttributes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0001F048 File Offset: 0x0001D248
		public unsafe virtual bool HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0001F090 File Offset: 0x0001D290
		[CallerCount(0)]
		public unsafe virtual IDtdAttributeListInfo LookupAttributeList(string prefix, string localName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_LookupAttributeList_Public_Abstract_Virtual_New_IDtdAttributeListInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeListInfo>(intPtr3) : null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001F100 File Offset: 0x0001D300
		[CallerCount(0)]
		public unsafe virtual IDtdEntityInfo LookupEntity(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_LookupEntity_Public_Abstract_Virtual_New_IDtdEntityInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002F8D File Offset: 0x0000118D
		public IDtdInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_XmlQualifiedName_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalDtdSubset_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultAttributes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_LookupAttributeList_Public_Abstract_Virtual_New_IDtdAttributeListInfo_String_String_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_LookupEntity_Public_Abstract_Virtual_New_IDtdEntityInfo_String_0;
	}
}
