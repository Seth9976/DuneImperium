using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.ui
{
	// Token: 0x0200009C RID: 156
	public class ISelectableValidator : Il2CppObjectBase
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x000056E7 File Offset: 0x000038E7
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectableValidator()
		{
			Il2CppClassPointerStore<ISelectableValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.ui", "ISelectableValidator");
			ISelectableValidator.NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectableValidator>.NativeClassPtr, 100664507);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00028F94 File Offset: 0x00027194
		[CallerCount(0)]
		public unsafe virtual bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectableValidator.NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00005716 File Offset: 0x00003916
		public ISelectableValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Boolean_0;
	}
}
