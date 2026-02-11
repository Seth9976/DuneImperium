using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000042 RID: 66
	public class IMeshModifier : Il2CppObjectBase
	{
		// Token: 0x0600082B RID: 2091 RVA: 0x00026F9C File Offset: 0x0002519C
		// Note: this type is marked as 'beforefieldinit'.
		static IMeshModifier()
		{
			Il2CppClassPointerStore<IMeshModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IMeshModifier");
			IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMeshModifier>.NativeClassPtr, 100664627);
			IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMeshModifier>.NativeClassPtr, 100664628);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00026FEC File Offset: 0x000251EC
		[CallerCount(0)]
		public unsafe virtual void ModifyMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0002703C File Offset: 0x0002523C
		[CallerCount(0)]
		public unsafe virtual void ModifyMesh(VertexHelper verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00004D37 File Offset: 0x00002F37
		public IMeshModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_Mesh_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0;
	}
}
