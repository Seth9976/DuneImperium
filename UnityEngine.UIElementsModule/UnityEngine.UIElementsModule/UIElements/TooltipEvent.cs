using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000123 RID: 291
	public class TooltipEvent : EventBase<TooltipEvent>
	{
		// Token: 0x060015ED RID: 5613 RVA: 0x0006AA6C File Offset: 0x00068C6C
		// Note: this type is marked as 'beforefieldinit'.
		static TooltipEvent()
		{
			Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TooltipEvent");
			TooltipEvent.NativeFieldInfoPtr__tooltip_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr, "<tooltip>k__BackingField");
			TooltipEvent.NativeFieldInfoPtr__rect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr, "<rect>k__BackingField");
			TooltipEvent.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr, 100666557);
			TooltipEvent.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr, 100666558);
			TooltipEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr, 100666559);
			TooltipEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr, 100666560);
			TooltipEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr, 100666561);
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x0000A38B File Offset: 0x0000858B
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x0006AB20 File Offset: 0x00068D20
		public unsafe string tooltip
		{
			get
			{
				return this._tooltip_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipEvent.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x0000A393 File Offset: 0x00008593
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x0006AB64 File Offset: 0x00068D64
		public unsafe Rect rect
		{
			get
			{
				return this._rect_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipEvent.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x0006ABA4 File Offset: 0x00068DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317130, XrefRangeEnd = 317137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x0006ABE0 File Offset: 0x00068DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317137, XrefRangeEnd = 317157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x0006AC14 File Offset: 0x00068E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317157, XrefRangeEnd = 317183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TooltipEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x0000A348 File Offset: 0x00008548
		public TooltipEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x0006AC50 File Offset: 0x00068E50
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x0000A351 File Offset: 0x00008551
		public unsafe string _tooltip_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipEvent.NativeFieldInfoPtr__tooltip_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipEvent.NativeFieldInfoPtr__tooltip_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0006AC78 File Offset: 0x00068E78
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x0000A370 File Offset: 0x00008570
		public unsafe Rect _rect_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipEvent.NativeFieldInfoPtr__rect_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipEvent.NativeFieldInfoPtr__rect_k__BackingField)) = value;
			}
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x0006ACA0 File Offset: 0x00068EA0
		public static TooltipEvent GetPooled(string tooltip, Rect rect)
		{
			TooltipEvent pooled = EventBase<TooltipEvent>.GetPooled();
			pooled.tooltip = tooltip;
			pooled.rect = rect;
			return pooled;
		}

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeFieldInfoPtr__tooltip_k__BackingField;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeFieldInfoPtr__rect_k__BackingField;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000458 RID: 1112
		[ObfuscatedName("UnityEngine.UIElements.TooltipEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003BB5 RID: 15285 RVA: 0x000F058C File Offset: 0x000EE78C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TooltipEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipEvent.__c>.NativeClassPtr);
				TooltipEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEvent.__c>.NativeClassPtr, "<>9");
				TooltipEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipEvent.__c>.NativeClassPtr, 100666563);
				TooltipEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TooltipEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipEvent.__c>.NativeClassPtr, 100666564);
			}

			// Token: 0x06003BB6 RID: 15286 RVA: 0x000F05F4 File Offset: 0x000EE7F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BB7 RID: 15287 RVA: 0x000F0630 File Offset: 0x000EE830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317117, XrefRangeEnd = 317130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TooltipEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TooltipEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TooltipEvent>(intPtr3) : null;
			}

			// Token: 0x06003BB8 RID: 15288 RVA: 0x00019106 File Offset: 0x00017306
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001227 RID: 4647
			// (get) Token: 0x06003BB9 RID: 15289 RVA: 0x000F0670 File Offset: 0x000EE870
			// (set) Token: 0x06003BBA RID: 15290 RVA: 0x0001910F File Offset: 0x0001730F
			public unsafe static TooltipEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TooltipEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A22 RID: 10786
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A23 RID: 10787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A24 RID: 10788
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_TooltipEvent_0;
		}

		// Token: 0x02000459 RID: 1113
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
