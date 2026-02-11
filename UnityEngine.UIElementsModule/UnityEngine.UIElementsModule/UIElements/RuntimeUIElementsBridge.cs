using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E0 RID: 480
	public class RuntimeUIElementsBridge : UIElementsBridge
	{
		// Token: 0x060025F9 RID: 9721 RVA: 0x000A9728 File Offset: 0x000A7928
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeUIElementsBridge()
		{
			Il2CppClassPointerStore<RuntimeUIElementsBridge>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RuntimeUIElementsBridge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeUIElementsBridge>.NativeClassPtr);
			RuntimeUIElementsBridge.NativeMethodInfoPtr_SetWantsMouseJumping_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUIElementsBridge>.NativeClassPtr, 100669050);
			RuntimeUIElementsBridge.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUIElementsBridge>.NativeClassPtr, 100669051);
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000A9780 File Offset: 0x000A7980
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWantsMouseJumping(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeUIElementsBridge.NativeMethodInfoPtr_SetWantsMouseJumping_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x000A97CC File Offset: 0x000A79CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeUIElementsBridge()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeUIElementsBridge>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUIElementsBridge.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x0000F7B4 File Offset: 0x0000D9B4
		public RuntimeUIElementsBridge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeMethodInfoPtr_SetWantsMouseJumping_Public_Virtual_Void_Int32_0;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
