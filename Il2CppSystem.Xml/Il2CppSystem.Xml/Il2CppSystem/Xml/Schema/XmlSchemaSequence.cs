using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D5 RID: 469
	public class XmlSchemaSequence : XmlSchemaGroupBase
	{
		// Token: 0x0600274C RID: 10060 RVA: 0x000B777C File Offset: 0x000B597C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSequence()
		{
			Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr);
			XmlSchemaSequence.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr, "items");
			XmlSchemaSequence.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr, 100668990);
			XmlSchemaSequence.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr, 100668991);
			XmlSchemaSequence.NativeMethodInfoPtr_SetItems_Internal_Virtual_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr, 100668992);
			XmlSchemaSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr, 100668993);
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x000B7810 File Offset: 0x000B5A10
		public unsafe override XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSequence.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x000B785C File Offset: 0x000B5A5C
		public unsafe override bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413295, XrefRangeEnd = 413300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSequence.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x000B78A4 File Offset: 0x000B5AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetItems(XmlSchemaObjectCollection newItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSequence.NativeMethodInfoPtr_SetItems_Internal_Virtual_Void_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x000B78F4 File Offset: 0x000B5AF4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 413306, RefRangeEnd = 413318, XrefRangeStart = 413300, XrefRangeEnd = 413306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00010A3C File Offset: 0x0000EC3C
		public XmlSchemaSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000B7930 File Offset: 0x000B5B30
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x00010A45 File Offset: 0x0000EC45
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSequence.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSequence.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr_SetItems_Internal_Virtual_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
