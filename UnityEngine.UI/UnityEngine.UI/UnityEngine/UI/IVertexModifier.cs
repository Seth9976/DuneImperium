using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000041 RID: 65
	public class IVertexModifier : Il2CppObjectBase
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x00004CFF File Offset: 0x00002EFF
		// Note: this type is marked as 'beforefieldinit'.
		static IVertexModifier()
		{
			Il2CppClassPointerStore<IVertexModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IVertexModifier");
			IVertexModifier.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVertexModifier>.NativeClassPtr, 100664626);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00026F4C File Offset: 0x0002514C
		[CallerCount(0)]
		public unsafe virtual void ModifyVertices(List<UIVertex> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVertexModifier.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00004D2E File Offset: 0x00002F2E
		public IVertexModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0;
	}
}
