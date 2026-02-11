using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F7 RID: 247
	public class MouseUpEvent : MouseEventBase<MouseUpEvent>
	{
		// Token: 0x06001424 RID: 5156 RVA: 0x000642A0 File Offset: 0x000624A0
		// Note: this type is marked as 'beforefieldinit'.
		static MouseUpEvent()
		{
			Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseUpEvent");
			MouseUpEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100666187);
			MouseUpEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100666188);
			MouseUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100666189);
			MouseUpEvent.NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseUpEvent_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100666190);
			MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100666191);
			MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100666192);
			MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, 100666193);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00064354 File Offset: 0x00062554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314875, XrefRangeEnd = 314878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseUpEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00064390 File Offset: 0x00062590
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000643C4 File Offset: 0x000625C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314878, XrefRangeEnd = 314881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseUpEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00064400 File Offset: 0x00062600
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314914, RefRangeEnd = 314917, XrefRangeStart = 314881, XrefRangeEnd = 314914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseUpEvent_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseUpEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00064444 File Offset: 0x00062644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314921, RefRangeEnd = 314922, XrefRangeStart = 314917, XrefRangeEnd = 314921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseUpEvent GetPooled(PointerUpEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerUpEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseUpEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00064488 File Offset: 0x00062688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314926, RefRangeEnd = 314927, XrefRangeStart = 314922, XrefRangeEnd = 314926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerMoveEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseUpEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000644CC File Offset: 0x000626CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314931, RefRangeEnd = 314932, XrefRangeStart = 314927, XrefRangeEnd = 314931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerCancelEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseUpEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00009A67 File Offset: 0x00007C67
		public MouseUpEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00064510 File Offset: 0x00062710
		public new static MouseUpEvent GetPooled(Event systemEvent)
		{
			bool flag = systemEvent != null;
			if (flag)
			{
				PointerDeviceState.ReleaseButton(PointerId.mousePointerId, systemEvent.button);
			}
			return MouseEventBase<MouseUpEvent>.GetPooled(systemEvent);
		}

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_MakeFromPointerEvent_Private_Static_MouseUpEvent_IPointerEvent_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerUpEvent_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerMoveEvent_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_MouseUpEvent_PointerCancelEvent_0;

		// Token: 0x0200041A RID: 1050
		[ObfuscatedName("UnityEngine.UIElements.MouseUpEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AFB RID: 15099 RVA: 0x000EE40C File Offset: 0x000EC60C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MouseUpEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseUpEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseUpEvent.__c>.NativeClassPtr);
				MouseUpEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseUpEvent.__c>.NativeClassPtr, "<>9");
				MouseUpEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent.__c>.NativeClassPtr, 100666195);
				MouseUpEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseUpEvent.__c>.NativeClassPtr, 100666196);
			}

			// Token: 0x06003AFC RID: 15100 RVA: 0x000EE474 File Offset: 0x000EC674
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseUpEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AFD RID: 15101 RVA: 0x000EE4B0 File Offset: 0x000EC6B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314869, XrefRangeEnd = 314875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseUpEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseUpEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseUpEvent>(intPtr3) : null;
			}

			// Token: 0x06003AFE RID: 15102 RVA: 0x00018DA2 File Offset: 0x00016FA2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001205 RID: 4613
			// (get) Token: 0x06003AFF RID: 15103 RVA: 0x000EE4F0 File Offset: 0x000EC6F0
			// (set) Token: 0x06003B00 RID: 15104 RVA: 0x00018DAB File Offset: 0x00016FAB
			public unsafe static MouseUpEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MouseUpEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseUpEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MouseUpEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029B3 RID: 10675
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029B4 RID: 10676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029B5 RID: 10677
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseUpEvent_0;
		}

		// Token: 0x0200041B RID: 1051
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
