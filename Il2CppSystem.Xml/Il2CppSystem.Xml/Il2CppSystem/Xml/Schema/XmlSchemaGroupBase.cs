using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C4 RID: 452
	public class XmlSchemaGroupBase : XmlSchemaParticle
	{
		// Token: 0x06002648 RID: 9800 RVA: 0x000B3A28 File Offset: 0x000B1C28
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaGroupBase()
		{
			Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaGroupBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr);
			XmlSchemaGroupBase.NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr, 100668832);
			XmlSchemaGroupBase.NativeMethodInfoPtr_SetItems_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr, 100668833);
			XmlSchemaGroupBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr, 100668834);
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x000B3A94 File Offset: 0x000B1C94
		public unsafe virtual XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaGroupBase.NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000B3AE0 File Offset: 0x000B1CE0
		[CallerCount(0)]
		public unsafe virtual void SetItems(XmlSchemaObjectCollection newItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaGroupBase.NativeMethodInfoPtr_SetItems_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000B3B30 File Offset: 0x000B1D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412330, RefRangeEnd = 412331, XrefRangeStart = 412326, XrefRangeEnd = 412330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaGroupBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00010431 File Offset: 0x0000E631
		public XmlSchemaGroupBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeMethodInfoPtr_SetItems_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
