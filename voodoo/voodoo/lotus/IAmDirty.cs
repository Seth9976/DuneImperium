using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000059 RID: 89
	public class IAmDirty : Il2CppObjectBase
	{
		// Token: 0x06000554 RID: 1364 RVA: 0x0001AEC8 File Offset: 0x000190C8
		// Note: this type is marked as 'beforefieldinit'.
		static IAmDirty()
		{
			Il2CppClassPointerStore<IAmDirty>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "IAmDirty");
			IAmDirty.NativeMethodInfoPtr_DirtyUpdate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAmDirty>.NativeClassPtr, 100663976);
			IAmDirty.NativeMethodInfoPtr_get_DirtyNode_Public_Abstract_Virtual_New_get_LinkedListNode_1_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAmDirty>.NativeClassPtr, 100663977);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0001AF18 File Offset: 0x00019118
		[CallerCount(0)]
		public unsafe virtual void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAmDirty.NativeMethodInfoPtr_DirtyUpdate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0001AF54 File Offset: 0x00019154
		public unsafe virtual LinkedListNode<IAmDirty> DirtyNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAmDirty.NativeMethodInfoPtr_get_DirtyNode_Public_Abstract_Virtual_New_get_LinkedListNode_1_IAmDirty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<IAmDirty>>(intPtr3) : null;
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000049E6 File Offset: 0x00002BE6
		public IAmDirty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_get_DirtyNode_Public_Abstract_Virtual_New_get_LinkedListNode_1_IAmDirty_0;
	}
}
