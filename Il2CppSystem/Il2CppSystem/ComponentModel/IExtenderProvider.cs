using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000112 RID: 274
	public class IExtenderProvider : Il2CppObjectBase
	{
		// Token: 0x0600111E RID: 4382 RVA: 0x00008087 File Offset: 0x00006287
		// Note: this type is marked as 'beforefieldinit'.
		static IExtenderProvider()
		{
			Il2CppClassPointerStore<IExtenderProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "IExtenderProvider");
			IExtenderProvider.NativeMethodInfoPtr_CanExtend_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExtenderProvider>.NativeClassPtr, 100665789);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0005D65C File Offset: 0x0005B85C
		[CallerCount(0)]
		public unsafe virtual bool CanExtend(Object extendee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extendee);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExtenderProvider.NativeMethodInfoPtr_CanExtend_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x000080B6 File Offset: 0x000062B6
		public IExtenderProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_CanExtend_Public_Abstract_Virtual_New_Boolean_Object_0;
	}
}
