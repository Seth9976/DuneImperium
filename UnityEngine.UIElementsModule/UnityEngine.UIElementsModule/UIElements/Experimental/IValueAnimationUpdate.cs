using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A8 RID: 680
	public class IValueAnimationUpdate : Il2CppObjectBase
	{
		// Token: 0x0600322C RID: 12844 RVA: 0x000144AD File Offset: 0x000126AD
		// Note: this type is marked as 'beforefieldinit'.
		static IValueAnimationUpdate()
		{
			Il2CppClassPointerStore<IValueAnimationUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "IValueAnimationUpdate");
			IValueAnimationUpdate.NativeMethodInfoPtr_Tick_Public_Abstract_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueAnimationUpdate>.NativeClassPtr, 100670588);
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000D4870 File Offset: 0x000D2A70
		[CallerCount(0)]
		public unsafe virtual void Tick(long currentTimeMs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentTimeMs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueAnimationUpdate.NativeMethodInfoPtr_Tick_Public_Abstract_Virtual_New_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000144DC File Offset: 0x000126DC
		public IValueAnimationUpdate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Public_Abstract_Virtual_New_Void_Int64_0;
	}
}
