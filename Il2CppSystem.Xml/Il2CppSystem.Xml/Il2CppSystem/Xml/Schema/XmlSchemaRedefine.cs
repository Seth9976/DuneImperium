using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D4 RID: 468
	public class XmlSchemaRedefine : XmlSchemaExternal
	{
		// Token: 0x0600273C RID: 10044 RVA: 0x000B7438 File Offset: 0x000B5638
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaRedefine()
		{
			Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaRedefine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr);
			XmlSchemaRedefine.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, "items");
			XmlSchemaRedefine.NativeFieldInfoPtr_attributeGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, "attributeGroups");
			XmlSchemaRedefine.NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, "types");
			XmlSchemaRedefine.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, "groups");
			XmlSchemaRedefine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668984);
			XmlSchemaRedefine.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668985);
			XmlSchemaRedefine.NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668986);
			XmlSchemaRedefine.NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668987);
			XmlSchemaRedefine.NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668988);
			XmlSchemaRedefine.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668989);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000B7530 File Offset: 0x000B5730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413292, RefRangeEnd = 413293, XrefRangeStart = 413273, XrefRangeEnd = 413292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaRedefine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x000B756C File Offset: 0x000B576C
		public unsafe XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x000B75AC File Offset: 0x000B57AC
		public unsafe XmlSchemaObjectTable AttributeGroups
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000B75EC File Offset: 0x000B57EC
		public unsafe XmlSchemaObjectTable SchemaTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x000B762C File Offset: 0x000B582C
		public unsafe XmlSchemaObjectTable Groups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000B766C File Offset: 0x000B586C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413293, XrefRangeEnd = 413295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaRedefine.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000109B7 File Offset: 0x0000EBB7
		public XmlSchemaRedefine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x000B76BC File Offset: 0x000B58BC
		// (set) Token: 0x06002745 RID: 10053 RVA: 0x000109C0 File Offset: 0x0000EBC0
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x000B76EC File Offset: 0x000B58EC
		// (set) Token: 0x06002747 RID: 10055 RVA: 0x000109DF File Offset: 0x0000EBDF
		public unsafe XmlSchemaObjectTable attributeGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_attributeGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_attributeGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x000B771C File Offset: 0x000B591C
		// (set) Token: 0x06002749 RID: 10057 RVA: 0x000109FE File Offset: 0x0000EBFE
		public unsafe XmlSchemaObjectTable types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x000B774C File Offset: 0x000B594C
		// (set) Token: 0x0600274B RID: 10059 RVA: 0x00010A1D File Offset: 0x0000EC1D
		public unsafe XmlSchemaObjectTable groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroups;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeFieldInfoPtr_types;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0;
	}
}
