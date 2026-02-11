using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x0200016B RID: 363
	public class TypeName : Il2CppObjectBase
	{
		// Token: 0x060018C3 RID: 6339 RVA: 0x00007EE6 File Offset: 0x000060E6
		// Note: this type is marked as 'beforefieldinit'.
		static TypeName()
		{
			Il2CppClassPointerStore<TypeName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeName");
			TypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeName>.NativeClassPtr, 100667579);
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0009ABD0 File Offset: 0x00098DD0
		public unsafe virtual string DisplayName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00007F15 File Offset: 0x00006115
		public TypeName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0;
	}
}
