using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003BA RID: 954
	[DefaultMember("Item")]
	public class ITuple : Il2CppObjectBase
	{
		// Token: 0x06003921 RID: 14625 RVA: 0x0001515B File Offset: 0x0001335B
		// Note: this type is marked as 'beforefieldinit'.
		static ITuple()
		{
			Il2CppClassPointerStore<ITuple>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ITuple");
			ITuple.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITuple>.NativeClassPtr, 100671827);
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x001150E8 File Offset: 0x001132E8
		public unsafe virtual int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITuple.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x0001518A File Offset: 0x0001338A
		public ITuple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
