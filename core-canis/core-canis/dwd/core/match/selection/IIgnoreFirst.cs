using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.match.selection
{
	// Token: 0x02000138 RID: 312
	public class IIgnoreFirst : Il2CppObjectBase
	{
		// Token: 0x06001191 RID: 4497 RVA: 0x00008153 File Offset: 0x00006353
		// Note: this type is marked as 'beforefieldinit'.
		static IIgnoreFirst()
		{
			Il2CppClassPointerStore<IIgnoreFirst>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IIgnoreFirst");
			IIgnoreFirst.NativeMethodInfoPtr_get_IgnoreFirst_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIgnoreFirst>.NativeClassPtr, 100665870);
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00059AD4 File Offset: 0x00057CD4
		public unsafe virtual bool IgnoreFirst
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIgnoreFirst.NativeMethodInfoPtr_get_IgnoreFirst_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00008182 File Offset: 0x00006382
		public IIgnoreFirst(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreFirst_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
