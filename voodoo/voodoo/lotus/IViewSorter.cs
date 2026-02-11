using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x0200005B RID: 91
	public class IViewSorter : Il2CppObjectBase
	{
		// Token: 0x06000561 RID: 1377 RVA: 0x000049F8 File Offset: 0x00002BF8
		// Note: this type is marked as 'beforefieldinit'.
		static IViewSorter()
		{
			Il2CppClassPointerStore<IViewSorter>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "IViewSorter");
			IViewSorter.NativeMethodInfoPtr_SortViews_Public_Abstract_Virtual_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewSorter>.NativeClassPtr, 100663997);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001B2B4 File Offset: 0x000194B4
		[CallerCount(0)]
		public unsafe virtual void SortViews(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IViewSorter.NativeMethodInfoPtr_SortViews_Public_Abstract_Virtual_New_Void_List_1_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00004A27 File Offset: 0x00002C27
		public IViewSorter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_SortViews_Public_Abstract_Virtual_New_Void_List_1_UnitView_0;
	}
}
