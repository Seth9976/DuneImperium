using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000108 RID: 264
	public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
	{
		// Token: 0x06001498 RID: 5272 RVA: 0x00065DA4 File Offset: 0x00063FA4
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationMoveEvent()
		{
			Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigationMoveEvent");
			NavigationMoveEvent.NativeFieldInfoPtr__direction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, "<direction>k__BackingField");
			NavigationMoveEvent.NativeFieldInfoPtr__move_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, "<move>k__BackingField");
			NavigationMoveEvent.NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666297);
			NavigationMoveEvent.NativeMethodInfoPtr_get_direction_Public_get_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666298);
			NavigationMoveEvent.NativeMethodInfoPtr_set_direction_Private_set_Void_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666299);
			NavigationMoveEvent.NativeMethodInfoPtr_set_move_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666300);
			NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Public_Static_NavigationMoveEvent_Vector2_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666301);
			NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_NavigationMoveEvent_Vector2_NavigationDeviceType_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666302);
			NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Public_Static_NavigationMoveEvent_Direction_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666303);
			NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_NavigationMoveEvent_Direction_NavigationDeviceType_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666304);
			NavigationMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666305);
			NavigationMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666306);
			NavigationMoveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100666307);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00065ED0 File Offset: 0x000640D0
		[CallerCount(0)]
		public unsafe static NavigationMoveEvent.Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x00065F2C File Offset: 0x0006412C
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x00065F68 File Offset: 0x00064168
		public unsafe NavigationMoveEvent.Direction direction
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_get_direction_Public_get_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_set_direction_Private_set_Void_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x00009C79 File Offset: 0x00007E79
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x00065FA8 File Offset: 0x000641A8
		public unsafe Vector2 move
		{
			get
			{
				return this._move_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_set_move_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00065FE8 File Offset: 0x000641E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315515, RefRangeEnd = 315516, XrefRangeStart = 315507, XrefRangeEnd = 315515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers = EventModifiers.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveVector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Public_Static_NavigationMoveEvent_Vector2_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationMoveEvent>(intPtr3) : null;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00066038 File Offset: 0x00064238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315524, RefRangeEnd = 315526, XrefRangeStart = 315516, XrefRangeEnd = 315524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveVector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_NavigationMoveEvent_Vector2_NavigationDeviceType_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationMoveEvent>(intPtr3) : null;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00066094 File Offset: 0x00064294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315531, RefRangeEnd = 315532, XrefRangeStart = 315526, XrefRangeEnd = 315531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NavigationMoveEvent GetPooled(NavigationMoveEvent.Direction direction, EventModifiers modifiers = EventModifiers.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Public_Static_NavigationMoveEvent_Direction_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationMoveEvent>(intPtr3) : null;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x000660E4 File Offset: 0x000642E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315537, RefRangeEnd = 315539, XrefRangeStart = 315532, XrefRangeEnd = 315537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NavigationMoveEvent GetPooled(NavigationMoveEvent.Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_NavigationMoveEvent_Direction_NavigationDeviceType_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationMoveEvent>(intPtr3) : null;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00066140 File Offset: 0x00064340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315539, XrefRangeEnd = 315544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavigationMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x0006617C File Offset: 0x0006437C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315544, XrefRangeEnd = 315549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationMoveEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x000661B8 File Offset: 0x000643B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315549, XrefRangeEnd = 315551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00009C3A File Offset: 0x00007E3A
		public NavigationMoveEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x000661EC File Offset: 0x000643EC
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x00009C43 File Offset: 0x00007E43
		public unsafe NavigationMoveEvent.Direction _direction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationMoveEvent.NativeFieldInfoPtr__direction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationMoveEvent.NativeFieldInfoPtr__direction_k__BackingField)) = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00066214 File Offset: 0x00064414
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x00009C5E File Offset: 0x00007E5E
		public unsafe Vector2 _move_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationMoveEvent.NativeFieldInfoPtr__move_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationMoveEvent.NativeFieldInfoPtr__move_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeFieldInfoPtr__direction_k__BackingField;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeFieldInfoPtr__move_k__BackingField;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Single_Single_Single_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_get_Direction_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Private_set_Void_Direction_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_set_move_Private_set_Void_Vector2_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_NavigationMoveEvent_Vector2_EventModifiers_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_NavigationMoveEvent_Vector2_NavigationDeviceType_EventModifiers_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_NavigationMoveEvent_Direction_EventModifiers_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_NavigationMoveEvent_Direction_NavigationDeviceType_EventModifiers_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x02000432 RID: 1074
		public enum Direction
		{
			// Token: 0x040029D7 RID: 10711
			None,
			// Token: 0x040029D8 RID: 10712
			Left,
			// Token: 0x040029D9 RID: 10713
			Up,
			// Token: 0x040029DA RID: 10714
			Right,
			// Token: 0x040029DB RID: 10715
			Down,
			// Token: 0x040029DC RID: 10716
			Next,
			// Token: 0x040029DD RID: 10717
			Previous
		}

		// Token: 0x02000433 RID: 1075
		[ObfuscatedName("UnityEngine.UIElements.NavigationMoveEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B3F RID: 15167 RVA: 0x000EF058 File Offset: 0x000ED258
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NavigationMoveEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationMoveEvent.__c>.NativeClassPtr);
				NavigationMoveEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationMoveEvent.__c>.NativeClassPtr, "<>9");
				NavigationMoveEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent.__c>.NativeClassPtr, 100666309);
				NavigationMoveEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_NavigationMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent.__c>.NativeClassPtr, 100666310);
			}

			// Token: 0x06003B40 RID: 15168 RVA: 0x000EF0C0 File Offset: 0x000ED2C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationMoveEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B41 RID: 15169 RVA: 0x000EF0FC File Offset: 0x000ED2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315499, XrefRangeEnd = 315507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationMoveEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_NavigationMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationMoveEvent>(intPtr3) : null;
			}

			// Token: 0x06003B42 RID: 15170 RVA: 0x00018ECB File Offset: 0x000170CB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001210 RID: 4624
			// (get) Token: 0x06003B43 RID: 15171 RVA: 0x000EF13C File Offset: 0x000ED33C
			// (set) Token: 0x06003B44 RID: 15172 RVA: 0x00018ED4 File Offset: 0x000170D4
			public unsafe static NavigationMoveEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationMoveEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationMoveEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationMoveEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029DE RID: 10718
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029DF RID: 10719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029E0 RID: 10720
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_NavigationMoveEvent_0;
		}

		// Token: 0x02000434 RID: 1076
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
