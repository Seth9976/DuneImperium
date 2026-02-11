using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200005B RID: 91
	public class ITextElement : Il2CppObjectBase
	{
		// Token: 0x06000A7A RID: 2682 RVA: 0x0002C764 File Offset: 0x0002A964
		// Note: this type is marked as 'beforefieldinit'.
		static ITextElement()
		{
			Il2CppClassPointerStore<ITextElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ITextElement");
			ITextElement.NativeMethodInfoPtr_get_sharedMaterial_Public_Abstract_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextElement>.NativeClassPtr, 100664482);
			ITextElement.NativeMethodInfoPtr_Rebuild_Public_Abstract_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextElement>.NativeClassPtr, 100664483);
			ITextElement.NativeMethodInfoPtr_GetInstanceID_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextElement>.NativeClassPtr, 100664484);
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0002C7C8 File Offset: 0x0002A9C8
		public unsafe virtual Material sharedMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextElement.NativeMethodInfoPtr_get_sharedMaterial_Public_Abstract_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0002C814 File Offset: 0x0002AA14
		[CallerCount(0)]
		public unsafe virtual void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextElement.NativeMethodInfoPtr_Rebuild_Public_Abstract_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002C860 File Offset: 0x0002AA60
		[CallerCount(0)]
		public unsafe virtual int GetInstanceID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextElement.NativeMethodInfoPtr_GetInstanceID_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00006CDA File Offset: 0x00004EDA
		public ITextElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_Abstract_Virtual_New_get_Material_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Abstract_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceID_Public_Abstract_Virtual_New_Int32_0;
	}
}
