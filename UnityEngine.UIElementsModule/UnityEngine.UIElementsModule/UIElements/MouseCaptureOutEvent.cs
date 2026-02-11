using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C3 RID: 195
	public class MouseCaptureOutEvent : MouseCaptureEventBase<MouseCaptureOutEvent>
	{
		// Token: 0x060011AC RID: 4524 RVA: 0x00008DF5 File Offset: 0x00006FF5
		// Note: this type is marked as 'beforefieldinit'.
		static MouseCaptureOutEvent()
		{
			Il2CppClassPointerStore<MouseCaptureOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseCaptureOutEvent");
			MouseCaptureOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureOutEvent>.NativeClassPtr, 100665789);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0005AB4C File Offset: 0x00058D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311924, XrefRangeEnd = 311927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseCaptureOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseCaptureOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00008E24 File Offset: 0x00007024
		public MouseCaptureOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003EF RID: 1007
		[ObfuscatedName("UnityEngine.UIElements.MouseCaptureOutEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003A99 RID: 15001 RVA: 0x000ED124 File Offset: 0x000EB324
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MouseCaptureOutEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseCaptureOutEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseCaptureOutEvent.__c>.NativeClassPtr);
				MouseCaptureOutEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseCaptureOutEvent.__c>.NativeClassPtr, "<>9");
				MouseCaptureOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureOutEvent.__c>.NativeClassPtr, 100665791);
				MouseCaptureOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseCaptureOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureOutEvent.__c>.NativeClassPtr, 100665792);
			}

			// Token: 0x06003A9A RID: 15002 RVA: 0x000ED18C File Offset: 0x000EB38C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseCaptureOutEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A9B RID: 15003 RVA: 0x000ED1C8 File Offset: 0x000EB3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311918, XrefRangeEnd = 311924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseCaptureOutEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseCaptureOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseCaptureOutEvent>(intPtr3) : null;
			}

			// Token: 0x06003A9C RID: 15004 RVA: 0x00018C0D File Offset: 0x00016E0D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011F6 RID: 4598
			// (get) Token: 0x06003A9D RID: 15005 RVA: 0x000ED208 File Offset: 0x000EB408
			// (set) Token: 0x06003A9E RID: 15006 RVA: 0x00018C16 File Offset: 0x00016E16
			public unsafe static MouseCaptureOutEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MouseCaptureOutEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseCaptureOutEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MouseCaptureOutEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002966 RID: 10598
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002967 RID: 10599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002968 RID: 10600
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseCaptureOutEvent_0;
		}

		// Token: 0x020003F0 RID: 1008
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
