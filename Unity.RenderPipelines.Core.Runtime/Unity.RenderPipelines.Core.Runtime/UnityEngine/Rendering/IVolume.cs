using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E5 RID: 229
	public class IVolume : Il2CppObjectBase
	{
		// Token: 0x06001085 RID: 4229 RVA: 0x0004C0FC File Offset: 0x0004A2FC
		// Note: this type is marked as 'beforefieldinit'.
		static IVolume()
		{
			Il2CppClassPointerStore<IVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "IVolume");
			IVolume.NativeMethodInfoPtr_get_isGlobal_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolume>.NativeClassPtr, 100665739);
			IVolume.NativeMethodInfoPtr_set_isGlobal_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolume>.NativeClassPtr, 100665740);
			IVolume.NativeMethodInfoPtr_get_colliders_Public_Abstract_Virtual_New_get_List_1_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVolume>.NativeClassPtr, 100665741);
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0004C160 File Offset: 0x0004A360
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x0004C1A8 File Offset: 0x0004A3A8
		public unsafe virtual bool isGlobal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolume.NativeMethodInfoPtr_get_isGlobal_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolume.NativeMethodInfoPtr_set_isGlobal_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0004C1F4 File Offset: 0x0004A3F4
		public unsafe virtual List<Collider> colliders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVolume.NativeMethodInfoPtr_get_colliders_Public_Abstract_Virtual_New_get_List_1_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr3) : null;
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00008BAD File Offset: 0x00006DAD
		public IVolume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_get_isGlobal_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_set_isGlobal_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_get_colliders_Public_Abstract_Virtual_New_get_List_1_Collider_0;
	}
}
