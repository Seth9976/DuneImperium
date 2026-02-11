using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000197 RID: 407
	public class XmlSchemaAll : XmlSchemaGroupBase
	{
		// Token: 0x0600239F RID: 9119 RVA: 0x000A9944 File Offset: 0x000A7B44
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAll()
		{
			Il2CppClassPointerStore<XmlSchemaAll>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAll");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAll>.NativeClassPtr);
			XmlSchemaAll.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAll>.NativeClassPtr, "items");
			XmlSchemaAll.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAll>.NativeClassPtr, 100668471);
			XmlSchemaAll.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAll>.NativeClassPtr, 100668472);
			XmlSchemaAll.NativeMethodInfoPtr_SetItems_Internal_Virtual_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAll>.NativeClassPtr, 100668473);
			XmlSchemaAll.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAll>.NativeClassPtr, 100668474);
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x000A99D8 File Offset: 0x000A7BD8
		public unsafe override XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAll.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x000A9A24 File Offset: 0x000A7C24
		public unsafe override bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410862, XrefRangeEnd = 410863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAll.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x000A9A6C File Offset: 0x000A7C6C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAll.NativeMethodInfoPtr_SetItems_Internal_Virtual_Void_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x000A9ABC File Offset: 0x000A7CBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 410872, RefRangeEnd = 410878, XrefRangeStart = 410863, XrefRangeEnd = 410872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAll()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAll>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAll.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		public XmlSchemaAll(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000A9AF8 File Offset: 0x000A7CF8
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x0000F1B5 File Offset: 0x0000D3B5
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAll.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAll.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_SetItems_Internal_Virtual_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
