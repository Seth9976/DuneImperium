using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000208 RID: 520
	public class IUxmlFactory : Il2CppObjectBase
	{
		// Token: 0x0600280F RID: 10255 RVA: 0x000102EA File Offset: 0x0000E4EA
		// Note: this type is marked as 'beforefieldinit'.
		static IUxmlFactory()
		{
			Il2CppClassPointerStore<IUxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IUxmlFactory");
			IUxmlFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUxmlFactory>.NativeClassPtr, 100669328);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000B03E4 File Offset: 0x000AE5E4
		[CallerCount(0)]
		public unsafe virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUxmlFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00010319 File Offset: 0x0000E519
		public IUxmlFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_VisualElement_IUxmlAttributes_CreationContext_0;
	}
}
