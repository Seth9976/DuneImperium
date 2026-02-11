using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DF RID: 479
	public class UIElementsBridge : Object
	{
		// Token: 0x060025F5 RID: 9717 RVA: 0x000A9648 File Offset: 0x000A7848
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsBridge()
		{
			Il2CppClassPointerStore<UIElementsBridge>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIElementsBridge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementsBridge>.NativeClassPtr);
			UIElementsBridge.NativeMethodInfoPtr_SetWantsMouseJumping_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsBridge>.NativeClassPtr, 100669048);
			UIElementsBridge.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsBridge>.NativeClassPtr, 100669049);
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x000A96A0 File Offset: 0x000A78A0
		[CallerCount(0)]
		public unsafe virtual void SetWantsMouseJumping(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIElementsBridge.NativeMethodInfoPtr_SetWantsMouseJumping_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000A96EC File Offset: 0x000A78EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIElementsBridge()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIElementsBridge>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsBridge.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x0000F7AB File Offset: 0x0000D9AB
		public UIElementsBridge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeMethodInfoPtr_SetWantsMouseJumping_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
