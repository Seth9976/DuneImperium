using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class ICanvasRaycastFilter : Il2CppObjectBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// Note: this type is marked as 'beforefieldinit'.
		static ICanvasRaycastFilter()
		{
			Il2CppClassPointerStore<ICanvasRaycastFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "ICanvasRaycastFilter");
			ICanvasRaycastFilter.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Abstract_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICanvasRaycastFilter>.NativeClassPtr, 100663297);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021AC File Offset: 0x000003AC
		[CallerCount(0)]
		public unsafe virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICanvasRaycastFilter.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Abstract_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000207F File Offset: 0x0000027F
		public ICanvasRaycastFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Abstract_Virtual_New_Boolean_Vector2_Camera_0;
	}
}
