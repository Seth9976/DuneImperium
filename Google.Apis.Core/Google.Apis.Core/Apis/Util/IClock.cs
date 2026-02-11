using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Google.Apis.Util
{
	// Token: 0x02000007 RID: 7
	public class IClock : Il2CppObjectBase
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00004D34 File Offset: 0x00002F34
		// Note: this type is marked as 'beforefieldinit'.
		static IClock()
		{
			Il2CppClassPointerStore<IClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Util", "IClock");
			IClock.NativeMethodInfoPtr_get_Now_Public_Abstract_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100663321);
			IClock.NativeMethodInfoPtr_get_UtcNow_Public_Abstract_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClock>.NativeClassPtr, 100663322);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004D84 File Offset: 0x00002F84
		public unsafe virtual DateTime Now
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_get_Now_Public_Abstract_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00004DCC File Offset: 0x00002FCC
		public unsafe virtual DateTime UtcNow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClock.NativeMethodInfoPtr_get_UtcNow_Public_Abstract_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000214B File Offset: 0x0000034B
		public IClock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_Now_Public_Abstract_Virtual_New_get_DateTime_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_UtcNow_Public_Abstract_Virtual_New_get_DateTime_0;
	}
}
