using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014C RID: 332
	public static class MouseCaptureController : Object
	{
		// Token: 0x06001862 RID: 6242 RVA: 0x000736C0 File Offset: 0x000718C0
		// Note: this type is marked as 'beforefieldinit'.
		static MouseCaptureController()
		{
			Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseCaptureController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr);
			MouseCaptureController.NativeMethodInfoPtr_HasMouseCapture_Public_Static_Boolean_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr, 100666914);
			MouseCaptureController.NativeMethodInfoPtr_CaptureMouse_Public_Static_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr, 100666915);
			MouseCaptureController.NativeMethodInfoPtr_ReleaseMouse_Public_Static_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureController>.NativeClassPtr, 100666916);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0007372C File Offset: 0x0007192C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320219, XrefRangeEnd = 320228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasMouseCapture(this IEventHandler handler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureController.NativeMethodInfoPtr_HasMouseCapture_Public_Static_Boolean_IEventHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00073770 File Offset: 0x00071970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320239, RefRangeEnd = 320241, XrefRangeStart = 320228, XrefRangeEnd = 320239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CaptureMouse(this IEventHandler handler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureController.NativeMethodInfoPtr_CaptureMouse_Public_Static_Void_IEventHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000737A8 File Offset: 0x000719A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320252, RefRangeEnd = 320253, XrefRangeStart = 320241, XrefRangeEnd = 320252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseMouse(this IEventHandler handler)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureController.NativeMethodInfoPtr_ReleaseMouse_Public_Static_Void_IEventHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0000B2E8 File Offset: 0x000094E8
		public MouseCaptureController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0000B2F1 File Offset: 0x000094F1
		public static bool IsMouseCaptured()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0000B2FE File Offset: 0x000094FE
		public static void ReleaseMouse()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_HasMouseCapture_Public_Static_Boolean_IEventHandler_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_CaptureMouse_Public_Static_Void_IEventHandler_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseMouse_Public_Static_Void_IEventHandler_0;
	}
}
