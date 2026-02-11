using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C4 RID: 196
	public class MouseCaptureEvent : MouseCaptureEventBase<MouseCaptureEvent>
	{
		// Token: 0x060011AF RID: 4527 RVA: 0x00008E2D File Offset: 0x0000702D
		// Note: this type is marked as 'beforefieldinit'.
		static MouseCaptureEvent()
		{
			Il2CppClassPointerStore<MouseCaptureEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseCaptureEvent");
			MouseCaptureEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureEvent>.NativeClassPtr, 100665794);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0005AB88 File Offset: 0x00058D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311933, XrefRangeEnd = 311952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseCaptureEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseCaptureEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00008E5C File Offset: 0x0000705C
		public MouseCaptureEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F1 RID: 1009
		[ObfuscatedName("UnityEngine.UIElements.MouseCaptureEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003A9F RID: 15007 RVA: 0x000ED230 File Offset: 0x000EB430
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MouseCaptureEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseCaptureEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseCaptureEvent.__c>.NativeClassPtr);
				MouseCaptureEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseCaptureEvent.__c>.NativeClassPtr, "<>9");
				MouseCaptureEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureEvent.__c>.NativeClassPtr, 100665796);
				MouseCaptureEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseCaptureEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureEvent.__c>.NativeClassPtr, 100665797);
			}

			// Token: 0x06003AA0 RID: 15008 RVA: 0x000ED298 File Offset: 0x000EB498
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseCaptureEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AA1 RID: 15009 RVA: 0x000ED2D4 File Offset: 0x000EB4D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311927, XrefRangeEnd = 311933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseCaptureEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseCaptureEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseCaptureEvent>(intPtr3) : null;
			}

			// Token: 0x06003AA2 RID: 15010 RVA: 0x00018C28 File Offset: 0x00016E28
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011F7 RID: 4599
			// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x000ED314 File Offset: 0x000EB514
			// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x00018C31 File Offset: 0x00016E31
			public unsafe static MouseCaptureEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MouseCaptureEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseCaptureEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MouseCaptureEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002969 RID: 10601
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400296A RID: 10602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400296B RID: 10603
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseCaptureEvent_0;
		}

		// Token: 0x020003F2 RID: 1010
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
