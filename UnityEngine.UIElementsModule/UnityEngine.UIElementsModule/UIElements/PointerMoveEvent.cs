using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000118 RID: 280
	public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
	{
		// Token: 0x060015A6 RID: 5542 RVA: 0x00069CB0 File Offset: 0x00067EB0
		// Note: this type is marked as 'beforefieldinit'.
		static PointerMoveEvent()
		{
			Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerMoveEvent");
			PointerMoveEvent.NativeFieldInfoPtr__isHandledByDraggable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, "<isHandledByDraggable>k__BackingField");
			PointerMoveEvent.NativeMethodInfoPtr_get_isHandledByDraggable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100666479);
			PointerMoveEvent.NativeMethodInfoPtr_set_isHandledByDraggable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100666480);
			PointerMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100666481);
			PointerMoveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100666482);
			PointerMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100666483);
			PointerMoveEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100666484);
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00069D64 File Offset: 0x00067F64
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x00069DA0 File Offset: 0x00067FA0
		public unsafe bool isHandledByDraggable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr_get_isHandledByDraggable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr_set_isHandledByDraggable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00069DE0 File Offset: 0x00067FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316659, XrefRangeEnd = 316667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00069E14 File Offset: 0x00068014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316667, XrefRangeEnd = 316672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00069E48 File Offset: 0x00068048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316672, XrefRangeEnd = 316680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerMoveEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00069E84 File Offset: 0x00068084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316680, XrefRangeEnd = 316738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0000A1E1 File Offset: 0x000083E1
		public PointerMoveEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x00069EC8 File Offset: 0x000680C8
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x0000A1EA File Offset: 0x000083EA
		public unsafe bool _isHandledByDraggable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerMoveEvent.NativeFieldInfoPtr__isHandledByDraggable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerMoveEvent.NativeFieldInfoPtr__isHandledByDraggable_k__BackingField)) = value;
			}
		}

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeFieldInfoPtr__isHandledByDraggable_k__BackingField;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_get_isHandledByDraggable_Internal_get_Boolean_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_set_isHandledByDraggable_Internal_set_Void_Boolean_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x02000441 RID: 1089
		[ObfuscatedName("UnityEngine.UIElements.PointerMoveEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B73 RID: 15219 RVA: 0x000EFA08 File Offset: 0x000EDC08
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerMoveEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerMoveEvent.__c>.NativeClassPtr);
				PointerMoveEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerMoveEvent.__c>.NativeClassPtr, "<>9");
				PointerMoveEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent.__c>.NativeClassPtr, 100666486);
				PointerMoveEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent.__c>.NativeClassPtr, 100666487);
			}

			// Token: 0x06003B74 RID: 15220 RVA: 0x000EFA70 File Offset: 0x000EDC70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerMoveEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B75 RID: 15221 RVA: 0x000EFAAC File Offset: 0x000EDCAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316648, XrefRangeEnd = 316659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerMoveEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerMoveEvent>(intPtr3) : null;
			}

			// Token: 0x06003B76 RID: 15222 RVA: 0x00018FDD File Offset: 0x000171DD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700121C RID: 4636
			// (get) Token: 0x06003B77 RID: 15223 RVA: 0x000EFAEC File Offset: 0x000EDCEC
			// (set) Token: 0x06003B78 RID: 15224 RVA: 0x00018FE6 File Offset: 0x000171E6
			public unsafe static PointerMoveEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerMoveEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerMoveEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerMoveEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029FD RID: 10749
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029FE RID: 10750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029FF RID: 10751
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerMoveEvent_0;
		}

		// Token: 0x02000442 RID: 1090
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
