using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F8 RID: 248
	public class MouseMoveEvent : MouseEventBase<MouseMoveEvent>
	{
		// Token: 0x0600142E RID: 5166 RVA: 0x00064544 File Offset: 0x00062744
		// Note: this type is marked as 'beforefieldinit'.
		static MouseMoveEvent()
		{
			Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseMoveEvent");
			MouseMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr, 100666198);
			MouseMoveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr, 100666199);
			MouseMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr, 100666200);
			MouseMoveEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseMoveEvent_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr, 100666201);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x000645BC File Offset: 0x000627BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314938, XrefRangeEnd = 314941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x000645F8 File Offset: 0x000627F8
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMoveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0006462C File Offset: 0x0006282C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314941, XrefRangeEnd = 314944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseMoveEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00064668 File Offset: 0x00062868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314947, RefRangeEnd = 314948, XrefRangeStart = 314944, XrefRangeEnd = 314947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMoveEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseMoveEvent_PointerMoveEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseMoveEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00009A70 File Offset: 0x00007C70
		public MouseMoveEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000646AC File Offset: 0x000628AC
		public new static MouseMoveEvent GetPooled(Event systemEvent)
		{
			MouseMoveEvent pooled = MouseEventBase<MouseMoveEvent>.GetPooled(systemEvent);
			pooled.button = 0;
			return pooled;
		}

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseMoveEvent_PointerMoveEvent_0;

		// Token: 0x0200041C RID: 1052
		[ObfuscatedName("UnityEngine.UIElements.MouseMoveEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B01 RID: 15105 RVA: 0x000EE518 File Offset: 0x000EC718
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MouseMoveEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseMoveEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseMoveEvent.__c>.NativeClassPtr);
				MouseMoveEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseMoveEvent.__c>.NativeClassPtr, "<>9");
				MouseMoveEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMoveEvent.__c>.NativeClassPtr, 100666203);
				MouseMoveEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMoveEvent.__c>.NativeClassPtr, 100666204);
			}

			// Token: 0x06003B02 RID: 15106 RVA: 0x000EE580 File Offset: 0x000EC780
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseMoveEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMoveEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B03 RID: 15107 RVA: 0x000EE5BC File Offset: 0x000EC7BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314932, XrefRangeEnd = 314938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseMoveEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMoveEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseMoveEvent>(intPtr3) : null;
			}

			// Token: 0x06003B04 RID: 15108 RVA: 0x00018DBD File Offset: 0x00016FBD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001206 RID: 4614
			// (get) Token: 0x06003B05 RID: 15109 RVA: 0x000EE5FC File Offset: 0x000EC7FC
			// (set) Token: 0x06003B06 RID: 15110 RVA: 0x00018DC6 File Offset: 0x00016FC6
			public unsafe static MouseMoveEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MouseMoveEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseMoveEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MouseMoveEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029B6 RID: 10678
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029B7 RID: 10679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029B8 RID: 10680
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseMoveEvent_0;
		}

		// Token: 0x0200041D RID: 1053
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
