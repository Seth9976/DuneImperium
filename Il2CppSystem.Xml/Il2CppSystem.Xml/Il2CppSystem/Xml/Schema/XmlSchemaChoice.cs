using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A0 RID: 416
	public class XmlSchemaChoice : XmlSchemaGroupBase
	{
		// Token: 0x06002459 RID: 9305 RVA: 0x000AC524 File Offset: 0x000AA724
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaChoice()
		{
			Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr);
			XmlSchemaChoice.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr, "items");
			XmlSchemaChoice.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr, 100668569);
			XmlSchemaChoice.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr, 100668570);
			XmlSchemaChoice.NativeMethodInfoPtr_SetItems_Internal_Virtual_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr, 100668571);
			XmlSchemaChoice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr, 100668572);
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x000AC5B8 File Offset: 0x000AA7B8
		public unsafe override XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaChoice.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x000AC604 File Offset: 0x000AA804
		public unsafe override bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411115, XrefRangeEnd = 411116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaChoice.NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x000AC64C File Offset: 0x000AA84C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaChoice.NativeMethodInfoPtr_SetItems_Internal_Virtual_Void_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x000AC69C File Offset: 0x000AA89C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 411125, RefRangeEnd = 411132, XrefRangeStart = 411116, XrefRangeEnd = 411125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaChoice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaChoice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0000F626 File Offset: 0x0000D826
		public XmlSchemaChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x000AC6D8 File Offset: 0x000AA8D8
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0000F62F File Offset: 0x0000D82F
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaChoice.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaChoice.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Internal_Virtual_get_Boolean_0;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_SetItems_Internal_Virtual_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
