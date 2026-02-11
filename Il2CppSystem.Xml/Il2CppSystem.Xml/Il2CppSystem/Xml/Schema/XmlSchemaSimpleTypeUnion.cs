using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001DE RID: 478
	public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
	{
		// Token: 0x06002807 RID: 10247 RVA: 0x000BA4B4 File Offset: 0x000B86B4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleTypeUnion()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleTypeUnion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr);
			XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, "baseTypes");
			XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, "memberTypes");
			XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseMemberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, "baseMemberTypes");
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_BaseTypes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100669085);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_MemberTypes_Public_get_Il2CppReferenceArray_1_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100669086);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_set_MemberTypes_Public_set_Void_Il2CppReferenceArray_1_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100669087);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_BaseMemberTypes_Public_get_Il2CppReferenceArray_1_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100669088);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_SetBaseMemberTypes_Internal_Void_Il2CppReferenceArray_1_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100669089);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100669090);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100669091);
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x000BA5AC File Offset: 0x000B87AC
		public unsafe XmlSchemaObjectCollection BaseTypes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_BaseTypes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x000BA5EC File Offset: 0x000B87EC
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x000BA62C File Offset: 0x000B882C
		public unsafe Il2CppReferenceArray<XmlQualifiedName> MemberTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_MemberTypes_Public_get_Il2CppReferenceArray_1_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlQualifiedName>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_set_MemberTypes_Public_set_Void_Il2CppReferenceArray_1_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x000BA670 File Offset: 0x000B8870
		public unsafe Il2CppReferenceArray<XmlSchemaSimpleType> BaseMemberTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_BaseMemberTypes_Public_get_Il2CppReferenceArray_1_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr3) : null;
			}
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000BA6B0 File Offset: 0x000B88B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBaseMemberTypes(Il2CppReferenceArray<XmlSchemaSimpleType> baseMemberTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMemberTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_SetBaseMemberTypes_Internal_Void_Il2CppReferenceArray_1_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000BA6F4 File Offset: 0x000B88F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414674, XrefRangeEnd = 414686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000BA740 File Offset: 0x000B8940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414692, RefRangeEnd = 414693, XrefRangeStart = 414686, XrefRangeEnd = 414692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleTypeUnion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x00010F39 File Offset: 0x0000F139
		public XmlSchemaSimpleTypeUnion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x000BA77C File Offset: 0x000B897C
		// (set) Token: 0x06002811 RID: 10257 RVA: 0x00010F42 File Offset: 0x0000F142
		public unsafe XmlSchemaObjectCollection baseTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x000BA7AC File Offset: 0x000B89AC
		// (set) Token: 0x06002813 RID: 10259 RVA: 0x00010F61 File Offset: 0x0000F161
		public unsafe Il2CppReferenceArray<XmlQualifiedName> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x000BA7DC File Offset: 0x000B89DC
		// (set) Token: 0x06002815 RID: 10261 RVA: 0x00010F80 File Offset: 0x0000F180
		public unsafe Il2CppReferenceArray<XmlSchemaSimpleType> baseMemberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseMemberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseMemberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeFieldInfoPtr_baseTypes;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeFieldInfoPtr_baseMemberTypes;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseTypes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberTypes_Public_get_Il2CppReferenceArray_1_XmlQualifiedName_0;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberTypes_Public_set_Void_Il2CppReferenceArray_1_XmlQualifiedName_0;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseMemberTypes_Public_get_Il2CppReferenceArray_1_XmlSchemaSimpleType_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr_SetBaseMemberTypes_Internal_Void_Il2CppReferenceArray_1_XmlSchemaSimpleType_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
