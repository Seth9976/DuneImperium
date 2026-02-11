using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x0200001E RID: 30
	public class IFreshRidePrompt : Il2CppObjectBase
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00007CE8 File Offset: 0x00005EE8
		// Note: this type is marked as 'beforefieldinit'.
		static IFreshRidePrompt()
		{
			Il2CppClassPointerStore<IFreshRidePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "IFreshRidePrompt");
			IFreshRidePrompt.NativeMethodInfoPtr_get_TheySeenMe_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFreshRidePrompt>.NativeClassPtr, 100663413);
			IFreshRidePrompt.NativeMethodInfoPtr_set_TheySeenMe_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFreshRidePrompt>.NativeClassPtr, 100663414);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00007D38 File Offset: 0x00005F38
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00007D80 File Offset: 0x00005F80
		public unsafe virtual bool TheySeenMe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFreshRidePrompt.NativeMethodInfoPtr_get_TheySeenMe_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFreshRidePrompt.NativeMethodInfoPtr_set_TheySeenMe_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002A39 File Offset: 0x00000C39
		public IFreshRidePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_TheySeenMe_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_set_TheySeenMe_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
