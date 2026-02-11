using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000024 RID: 36
	public class ILayoutIgnorer : Il2CppObjectBase
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x00003814 File Offset: 0x00001A14
		// Note: this type is marked as 'beforefieldinit'.
		static ILayoutIgnorer()
		{
			Il2CppClassPointerStore<ILayoutIgnorer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ILayoutIgnorer");
			ILayoutIgnorer.NativeMethodInfoPtr_get_ignoreLayout_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutIgnorer>.NativeClassPtr, 100663994);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00017D74 File Offset: 0x00015F74
		public unsafe virtual bool ignoreLayout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutIgnorer.NativeMethodInfoPtr_get_ignoreLayout_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00003843 File Offset: 0x00001A43
		public ILayoutIgnorer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreLayout_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
