using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000022 RID: 34
	public class IBindingRequest : Il2CppObjectBase
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00002838 File Offset: 0x00000A38
		// Note: this type is marked as 'beforefieldinit'.
		static IBindingRequest()
		{
			Il2CppClassPointerStore<IBindingRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IBindingRequest");
			IBindingRequest.NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingRequest>.NativeClassPtr, 100663551);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000235E0 File Offset: 0x000217E0
		[CallerCount(0)]
		public unsafe virtual void Bind(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingRequest.NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002867 File Offset: 0x00000A67
		public IBindingRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_Void_VisualElement_0;
	}
}
