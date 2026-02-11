using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F6 RID: 246
	public class MouseDownEvent : MouseEventBase<MouseDownEvent>
	{
		// Token: 0x0600141B RID: 5147 RVA: 0x00064054 File Offset: 0x00062254
		// Note: this type is marked as 'beforefieldinit'.
		static MouseDownEvent()
		{
			Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseDownEvent");
			MouseDownEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100666177);
			MouseDownEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100666178);
			MouseDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100666179);
			MouseDownEvent.NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseDownEvent_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100666180);
			MouseDownEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100666181);
			MouseDownEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, 100666182);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x000640F4 File Offset: 0x000622F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314818, XrefRangeEnd = 314821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseDownEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00064130 File Offset: 0x00062330
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00064164 File Offset: 0x00062364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314821, XrefRangeEnd = 314824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseDownEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x000641A0 File Offset: 0x000623A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314857, RefRangeEnd = 314859, XrefRangeStart = 314824, XrefRangeEnd = 314857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseDownEvent_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseDownEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x000641E4 File Offset: 0x000623E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314863, RefRangeEnd = 314864, XrefRangeStart = 314859, XrefRangeEnd = 314863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseDownEvent GetPooled(PointerDownEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerDownEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseDownEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00064228 File Offset: 0x00062428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314868, RefRangeEnd = 314869, XrefRangeStart = 314864, XrefRangeEnd = 314868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerMoveEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseDownEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00009A5E File Offset: 0x00007C5E
		public MouseDownEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0006426C File Offset: 0x0006246C
		public new static MouseDownEvent GetPooled(Event systemEvent)
		{
			bool flag = systemEvent != null;
			if (flag)
			{
				PointerDeviceState.PressButton(PointerId.mousePointerId, systemEvent.button);
			}
			return MouseEventBase<MouseDownEvent>.GetPooled(systemEvent);
		}

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseDownEvent_IPointerEvent_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerDownEvent_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseDownEvent_PointerMoveEvent_0;

		// Token: 0x02000418 RID: 1048
		[ObfuscatedName("UnityEngine.UIElements.MouseDownEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AF5 RID: 15093 RVA: 0x000EE300 File Offset: 0x000EC500
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MouseDownEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseDownEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseDownEvent.__c>.NativeClassPtr);
				MouseDownEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseDownEvent.__c>.NativeClassPtr, "<>9");
				MouseDownEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent.__c>.NativeClassPtr, 100666184);
				MouseDownEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseDownEvent.__c>.NativeClassPtr, 100666185);
			}

			// Token: 0x06003AF6 RID: 15094 RVA: 0x000EE368 File Offset: 0x000EC568
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseDownEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AF7 RID: 15095 RVA: 0x000EE3A4 File Offset: 0x000EC5A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314812, XrefRangeEnd = 314818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseDownEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseDownEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseDownEvent>(intPtr3) : null;
			}

			// Token: 0x06003AF8 RID: 15096 RVA: 0x00018D87 File Offset: 0x00016F87
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001204 RID: 4612
			// (get) Token: 0x06003AF9 RID: 15097 RVA: 0x000EE3E4 File Offset: 0x000EC5E4
			// (set) Token: 0x06003AFA RID: 15098 RVA: 0x00018D90 File Offset: 0x00016F90
			public unsafe static MouseDownEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MouseDownEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseDownEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MouseDownEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029B0 RID: 10672
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029B1 RID: 10673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029B2 RID: 10674
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseDownEvent_0;
		}

		// Token: 0x02000419 RID: 1049
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
