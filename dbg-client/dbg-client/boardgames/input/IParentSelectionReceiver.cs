using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.input
{
	// Token: 0x02000139 RID: 313
	public class IParentSelectionReceiver : Il2CppObjectBase
	{
		// Token: 0x06000E20 RID: 3616 RVA: 0x00008CF8 File Offset: 0x00006EF8
		// Note: this type is marked as 'beforefieldinit'.
		static IParentSelectionReceiver()
		{
			Il2CppClassPointerStore<IParentSelectionReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "IParentSelectionReceiver");
			IParentSelectionReceiver.NativeMethodInfoPtr_get_SelectionID_Public_Abstract_Virtual_New_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParentSelectionReceiver>.NativeClassPtr, 100665352);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0004A7D8 File Offset: 0x000489D8
		public unsafe virtual EntityID SelectionID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IParentSelectionReceiver.NativeMethodInfoPtr_get_SelectionID_Public_Abstract_Virtual_New_get_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00008D27 File Offset: 0x00006F27
		public IParentSelectionReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionID_Public_Abstract_Virtual_New_get_EntityID_0;
	}
}
