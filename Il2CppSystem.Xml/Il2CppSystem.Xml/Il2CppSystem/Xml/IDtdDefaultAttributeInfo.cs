using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000022 RID: 34
	public class IDtdDefaultAttributeInfo : Il2CppObjectBase
	{
		// Token: 0x06000274 RID: 628 RVA: 0x0001F568 File Offset: 0x0001D768
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdDefaultAttributeInfo()
		{
			Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdDefaultAttributeInfo");
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueExpanded_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663621);
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueTyped_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663622);
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLineNumber_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663623);
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLinePosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663624);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0001F5E0 File Offset: 0x0001D7E0
		public unsafe virtual string DefaultValueExpanded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueExpanded_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0001F624 File Offset: 0x0001D824
		public unsafe virtual Object DefaultValueTyped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueTyped_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0001F670 File Offset: 0x0001D870
		public unsafe virtual int ValueLineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLineNumber_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0001F6B8 File Offset: 0x0001D8B8
		public unsafe virtual int ValueLinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLinePosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002FA8 File Offset: 0x000011A8
		public IDtdDefaultAttributeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueExpanded_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueTyped_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLineNumber_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLinePosition_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
