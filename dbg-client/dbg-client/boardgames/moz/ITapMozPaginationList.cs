using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace boardgames.moz
{
	// Token: 0x02000117 RID: 279
	public class ITapMozPaginationList : Il2CppObjectBase
	{
		// Token: 0x06000C8A RID: 3210 RVA: 0x00008146 File Offset: 0x00006346
		// Note: this type is marked as 'beforefieldinit'.
		static ITapMozPaginationList()
		{
			Il2CppClassPointerStore<ITapMozPaginationList>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "ITapMozPaginationList");
			ITapMozPaginationList.NativeMethodInfoPtr_GetViews_Public_Abstract_Virtual_New_IReadOnlyList_1_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITapMozPaginationList>.NativeClassPtr, 100665125);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00045234 File Offset: 0x00043434
		[CallerCount(0)]
		public unsafe virtual IReadOnlyList<EntityView> GetViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITapMozPaginationList.NativeMethodInfoPtr_GetViews_Public_Abstract_Virtual_New_IReadOnlyList_1_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EntityView>>(intPtr3) : null;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00008175 File Offset: 0x00006375
		public ITapMozPaginationList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_GetViews_Public_Abstract_Virtual_New_IReadOnlyList_1_EntityView_0;
	}
}
