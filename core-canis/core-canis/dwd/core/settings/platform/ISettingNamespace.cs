using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.settings.platform
{
	// Token: 0x020000DF RID: 223
	public class ISettingNamespace : Il2CppObjectBase
	{
		// Token: 0x06000D7E RID: 3454 RVA: 0x000483F0 File Offset: 0x000465F0
		// Note: this type is marked as 'beforefieldinit'.
		static ISettingNamespace()
		{
			Il2CppClassPointerStore<ISettingNamespace>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform", "ISettingNamespace");
			ISettingNamespace.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingNamespace>.NativeClassPtr, 100665219);
			ISettingNamespace.NativeMethodInfoPtr_HasChanged_Public_Abstract_Virtual_New_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingNamespace>.NativeClassPtr, 100665220);
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00048440 File Offset: 0x00046640
		public unsafe virtual string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISettingNamespace.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00048484 File Offset: 0x00046684
		[CallerCount(0)]
		public unsafe virtual bool HasChanged(out bool shouldReSave)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &shouldReSave;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISettingNamespace.NativeMethodInfoPtr_HasChanged_Public_Abstract_Virtual_New_Boolean_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00006AA1 File Offset: 0x00004CA1
		public ISettingNamespace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_HasChanged_Public_Abstract_Virtual_New_Boolean_byref_Boolean_0;
	}
}
