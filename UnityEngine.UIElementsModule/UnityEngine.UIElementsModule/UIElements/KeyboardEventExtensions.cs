using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EE RID: 238
	public static class KeyboardEventExtensions : Object
	{
		// Token: 0x060013A1 RID: 5025 RVA: 0x0006204C File Offset: 0x0006024C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardEventExtensions()
		{
			Il2CppClassPointerStore<KeyboardEventExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyboardEventExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardEventExtensions>.NativeClassPtr);
			KeyboardEventExtensions.NativeMethodInfoPtr_ShouldSendNavigationMoveEvent_Internal_Static_Boolean_KeyDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventExtensions>.NativeClassPtr, 100666091);
			KeyboardEventExtensions.NativeMethodInfoPtr_ShouldSendNavigationMoveEventRuntime_Internal_Static_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardEventExtensions>.NativeClassPtr, 100666092);
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x000620A4 File Offset: 0x000602A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314371, RefRangeEnd = 314373, XrefRangeStart = 314358, XrefRangeEnd = 314371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldSendNavigationMoveEvent(this KeyDownEvent e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventExtensions.NativeMethodInfoPtr_ShouldSendNavigationMoveEvent_Internal_Static_Boolean_KeyDownEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x000620E8 File Offset: 0x000602E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314374, RefRangeEnd = 314377, XrefRangeStart = 314373, XrefRangeEnd = 314374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldSendNavigationMoveEventRuntime(this Event e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardEventExtensions.NativeMethodInfoPtr_ShouldSendNavigationMoveEventRuntime_Internal_Static_Boolean_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00009884 File Offset: 0x00007A84
		public KeyboardEventExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendNavigationMoveEvent_Internal_Static_Boolean_KeyDownEvent_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendNavigationMoveEventRuntime_Internal_Static_Boolean_Event_0;
	}
}
