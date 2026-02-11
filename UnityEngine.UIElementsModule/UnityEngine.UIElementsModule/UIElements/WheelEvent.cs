using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FA RID: 250
	public class WheelEvent : MouseEventBase<WheelEvent>
	{
		// Token: 0x06001438 RID: 5176 RVA: 0x0006470C File Offset: 0x0006290C
		// Note: this type is marked as 'beforefieldinit'.
		static WheelEvent()
		{
			Il2CppClassPointerStore<WheelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "WheelEvent");
			WheelEvent.NativeFieldInfoPtr__delta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, "<delta>k__BackingField");
			WheelEvent.NativeMethodInfoPtr_get_delta_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100666211);
			WheelEvent.NativeMethodInfoPtr_set_delta_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100666212);
			WheelEvent.NativeMethodInfoPtr_GetPooled_Public_Static_WheelEvent_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100666213);
			WheelEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_WheelEvent_Vector3_Vector3_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100666214);
			WheelEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_WheelEvent_Vector3_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100666215);
			WheelEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100666216);
			WheelEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100666217);
			WheelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100666218);
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x000647E8 File Offset: 0x000629E8
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x00064824 File Offset: 0x00062A24
		public unsafe Vector3 delta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_get_delta_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_set_delta_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00064864 File Offset: 0x00062A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314973, RefRangeEnd = 314974, XrefRangeStart = 314965, XrefRangeEnd = 314973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static WheelEvent GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_GetPooled_Public_Static_WheelEvent_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WheelEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000648A8 File Offset: 0x00062AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314974, XrefRangeEnd = 314982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers = EventModifiers.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_WheelEvent_Vector3_Vector3_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WheelEvent>(intPtr3) : null;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00064904 File Offset: 0x00062B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314985, RefRangeEnd = 314986, XrefRangeStart = 314982, XrefRangeEnd = 314985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_WheelEvent_Vector3_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WheelEvent>(intPtr3) : null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00064958 File Offset: 0x00062B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314986, XrefRangeEnd = 314991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WheelEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00064994 File Offset: 0x00062B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314991, XrefRangeEnd = 314993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000649C8 File Offset: 0x00062BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314993, XrefRangeEnd = 314998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00009AB1 File Offset: 0x00007CB1
		public WheelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00064A04 File Offset: 0x00062C04
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x00009ABA File Offset: 0x00007CBA
		public unsafe Vector3 _delta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelEvent.NativeFieldInfoPtr__delta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelEvent.NativeFieldInfoPtr__delta_k__BackingField)) = value;
			}
		}

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeFieldInfoPtr__delta_k__BackingField;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Public_get_Vector3_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_set_delta_Private_set_Void_Vector3_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_WheelEvent_Event_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_WheelEvent_Vector3_Vector3_EventModifiers_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_WheelEvent_Vector3_IPointerEvent_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000420 RID: 1056
		[ObfuscatedName("UnityEngine.UIElements.WheelEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B0D RID: 15117 RVA: 0x000EE730 File Offset: 0x000EC930
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WheelEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelEvent.__c>.NativeClassPtr);
				WheelEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelEvent.__c>.NativeClassPtr, "<>9");
				WheelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent.__c>.NativeClassPtr, 100666220);
				WheelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_WheelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent.__c>.NativeClassPtr, 100666221);
			}

			// Token: 0x06003B0E RID: 15118 RVA: 0x000EE798 File Offset: 0x000EC998
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B0F RID: 15119 RVA: 0x000EE7D4 File Offset: 0x000EC9D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314957, XrefRangeEnd = 314965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WheelEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_WheelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WheelEvent>(intPtr3) : null;
			}

			// Token: 0x06003B10 RID: 15120 RVA: 0x00018DF3 File Offset: 0x00016FF3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001208 RID: 4616
			// (get) Token: 0x06003B11 RID: 15121 RVA: 0x000EE814 File Offset: 0x000ECA14
			// (set) Token: 0x06003B12 RID: 15122 RVA: 0x00018DFC File Offset: 0x00016FFC
			public unsafe static WheelEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WheelEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WheelEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WheelEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029BC RID: 10684
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029BD RID: 10685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029BE RID: 10686
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_WheelEvent_0;
		}

		// Token: 0x02000421 RID: 1057
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
