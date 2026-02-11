using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F0 RID: 240
	public class GeometryChangedEvent : EventBase<GeometryChangedEvent>
	{
		// Token: 0x060013A8 RID: 5032 RVA: 0x00062168 File Offset: 0x00060368
		// Note: this type is marked as 'beforefieldinit'.
		static GeometryChangedEvent()
		{
			Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "GeometryChangedEvent");
			GeometryChangedEvent.NativeFieldInfoPtr__oldRect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, "<oldRect>k__BackingField");
			GeometryChangedEvent.NativeFieldInfoPtr__newRect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, "<newRect>k__BackingField");
			GeometryChangedEvent.NativeFieldInfoPtr__layoutPass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, "<layoutPass>k__BackingField");
			GeometryChangedEvent.NativeMethodInfoPtr_GetPooled_Public_Static_GeometryChangedEvent_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666099);
			GeometryChangedEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666100);
			GeometryChangedEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666101);
			GeometryChangedEvent.NativeMethodInfoPtr_get_oldRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666102);
			GeometryChangedEvent.NativeMethodInfoPtr_set_oldRect_Private_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666103);
			GeometryChangedEvent.NativeMethodInfoPtr_get_newRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666104);
			GeometryChangedEvent.NativeMethodInfoPtr_set_newRect_Private_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666105);
			GeometryChangedEvent.NativeMethodInfoPtr_get_layoutPass_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666106);
			GeometryChangedEvent.NativeMethodInfoPtr_set_layoutPass_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666107);
			GeometryChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, 100666108);
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00062294 File Offset: 0x00060494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314403, RefRangeEnd = 314404, XrefRangeStart = 314397, XrefRangeEnd = 314403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.NativeMethodInfoPtr_GetPooled_Public_Static_GeometryChangedEvent_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GeometryChangedEvent>(intPtr3) : null;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x000622E4 File Offset: 0x000604E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314404, XrefRangeEnd = 314409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeometryChangedEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00062320 File Offset: 0x00060520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314409, XrefRangeEnd = 314411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00062354 File Offset: 0x00060554
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x00062390 File Offset: 0x00060590
		public unsafe Rect oldRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.NativeMethodInfoPtr_get_oldRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.NativeMethodInfoPtr_set_oldRect_Private_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x000623D0 File Offset: 0x000605D0
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x0006240C File Offset: 0x0006060C
		public unsafe Rect newRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.NativeMethodInfoPtr_get_newRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.NativeMethodInfoPtr_set_newRect_Private_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0006244C File Offset: 0x0006064C
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x00062488 File Offset: 0x00060688
		public unsafe int layoutPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.NativeMethodInfoPtr_get_layoutPass_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.NativeMethodInfoPtr_set_layoutPass_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x000624C8 File Offset: 0x000606C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314411, XrefRangeEnd = 314419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeometryChangedEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000098C5 File Offset: 0x00007AC5
		public GeometryChangedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00062504 File Offset: 0x00060704
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x000098CE File Offset: 0x00007ACE
		public unsafe Rect _oldRect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeometryChangedEvent.NativeFieldInfoPtr__oldRect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeometryChangedEvent.NativeFieldInfoPtr__oldRect_k__BackingField)) = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0006252C File Offset: 0x0006072C
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x000098E9 File Offset: 0x00007AE9
		public unsafe Rect _newRect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeometryChangedEvent.NativeFieldInfoPtr__newRect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeometryChangedEvent.NativeFieldInfoPtr__newRect_k__BackingField)) = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00062554 File Offset: 0x00060754
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x00009904 File Offset: 0x00007B04
		public unsafe int _layoutPass_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeometryChangedEvent.NativeFieldInfoPtr__layoutPass_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeometryChangedEvent.NativeFieldInfoPtr__layoutPass_k__BackingField)) = value;
			}
		}

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeFieldInfoPtr__oldRect_k__BackingField;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeFieldInfoPtr__newRect_k__BackingField;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeFieldInfoPtr__layoutPass_k__BackingField;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_GeometryChangedEvent_Rect_Rect_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_get_oldRect_Public_get_Rect_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_set_oldRect_Private_set_Void_Rect_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_get_newRect_Public_get_Rect_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_set_newRect_Private_set_Void_Rect_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPass_Internal_get_Int32_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_set_layoutPass_Internal_set_Void_Int32_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000415 RID: 1045
		[ObfuscatedName("UnityEngine.UIElements.GeometryChangedEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AEF RID: 15087 RVA: 0x000EE1F4 File Offset: 0x000EC3F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GeometryChangedEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeometryChangedEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeometryChangedEvent.__c>.NativeClassPtr);
				GeometryChangedEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeometryChangedEvent.__c>.NativeClassPtr, "<>9");
				GeometryChangedEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent.__c>.NativeClassPtr, 100666110);
				GeometryChangedEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryChangedEvent.__c>.NativeClassPtr, 100666111);
			}

			// Token: 0x06003AF0 RID: 15088 RVA: 0x000EE25C File Offset: 0x000EC45C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeometryChangedEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AF1 RID: 15089 RVA: 0x000EE298 File Offset: 0x000EC498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314386, XrefRangeEnd = 314397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GeometryChangedEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryChangedEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GeometryChangedEvent>(intPtr3) : null;
			}

			// Token: 0x06003AF2 RID: 15090 RVA: 0x00018D6C File Offset: 0x00016F6C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001203 RID: 4611
			// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x000EE2D8 File Offset: 0x000EC4D8
			// (set) Token: 0x06003AF4 RID: 15092 RVA: 0x00018D75 File Offset: 0x00016F75
			public unsafe static GeometryChangedEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GeometryChangedEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeometryChangedEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GeometryChangedEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029A9 RID: 10665
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029AA RID: 10666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029AB RID: 10667
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_GeometryChangedEvent_0;
		}

		// Token: 0x02000416 RID: 1046
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
