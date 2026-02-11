using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022C RID: 556
	public class VisualElementFocusChangeTarget : FocusChangeDirection
	{
		// Token: 0x06002948 RID: 10568 RVA: 0x000B4950 File Offset: 0x000B2B50
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementFocusChangeTarget()
		{
			Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementFocusChangeTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr);
			VisualElementFocusChangeTarget.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr, "Pool");
			VisualElementFocusChangeTarget.NativeFieldInfoPtr__target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr, "<target>k__BackingField");
			VisualElementFocusChangeTarget.NativeMethodInfoPtr_GetPooled_Public_Static_VisualElementFocusChangeTarget_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr, 100669495);
			VisualElementFocusChangeTarget.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr, 100669496);
			VisualElementFocusChangeTarget.NativeMethodInfoPtr_ApplyTo_Internal_Virtual_Void_FocusController_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr, 100669497);
			VisualElementFocusChangeTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr, 100669498);
			VisualElementFocusChangeTarget.NativeMethodInfoPtr_get_target_Public_get_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr, 100669499);
			VisualElementFocusChangeTarget.NativeMethodInfoPtr_set_target_Private_set_Void_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr, 100669500);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000B4A20 File Offset: 0x000B2C20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346393, RefRangeEnd = 346394, XrefRangeStart = 346385, XrefRangeEnd = 346393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElementFocusChangeTarget GetPooled(Focusable target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeTarget.NativeMethodInfoPtr_GetPooled_Public_Static_VisualElementFocusChangeTarget_Focusable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElementFocusChangeTarget>(intPtr3) : null;
			}
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000B4A64 File Offset: 0x000B2C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346394, XrefRangeEnd = 346403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualElementFocusChangeTarget.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000B4AA0 File Offset: 0x000B2CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346403, XrefRangeEnd = 346405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyTo(FocusController focusController, Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusController);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(f);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualElementFocusChangeTarget.NativeMethodInfoPtr_ApplyTo_Internal_Virtual_Void_FocusController_Focusable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000B4B00 File Offset: 0x000B2D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346405, XrefRangeEnd = 346414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElementFocusChangeTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x000B4B3C File Offset: 0x000B2D3C
		// (set) Token: 0x0600294E RID: 10574 RVA: 0x000B4B7C File Offset: 0x000B2D7C
		public unsafe Focusable target
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeTarget.NativeMethodInfoPtr_get_target_Public_get_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeTarget.NativeMethodInfoPtr_set_target_Private_set_Void_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00010A73 File Offset: 0x0000EC73
		public VisualElementFocusChangeTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000B4BC0 File Offset: 0x000B2DC0
		// (set) Token: 0x06002951 RID: 10577 RVA: 0x00010A7C File Offset: 0x0000EC7C
		public unsafe static ObjectPool<VisualElementFocusChangeTarget> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementFocusChangeTarget.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<VisualElementFocusChangeTarget>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementFocusChangeTarget.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x000B4BE8 File Offset: 0x000B2DE8
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x00010A8E File Offset: 0x0000EC8E
		public unsafe Focusable _target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusChangeTarget.NativeFieldInfoPtr__target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusChangeTarget.NativeFieldInfoPtr__target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeFieldInfoPtr__target_k__BackingField;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_VisualElementFocusChangeTarget_Focusable_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTo_Internal_Virtual_Void_FocusController_Focusable_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_Focusable_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_set_target_Private_set_Void_Focusable_0;

		// Token: 0x0200052E RID: 1326
		[ObfuscatedName("UnityEngine.UIElements.VisualElementFocusChangeTarget+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004090 RID: 16528 RVA: 0x001000BC File Offset: 0x000FE2BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VisualElementFocusChangeTarget.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualElementFocusChangeTarget>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementFocusChangeTarget.__c>.NativeClassPtr);
				VisualElementFocusChangeTarget.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusChangeTarget.__c>.NativeClassPtr, "<>9");
				VisualElementFocusChangeTarget.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeTarget.__c>.NativeClassPtr, 100669503);
				VisualElementFocusChangeTarget.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_VisualElementFocusChangeTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeTarget.__c>.NativeClassPtr, 100669504);
			}

			// Token: 0x06004091 RID: 16529 RVA: 0x00100124 File Offset: 0x000FE324
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementFocusChangeTarget.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeTarget.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004092 RID: 16530 RVA: 0x00100160 File Offset: 0x000FE360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346373, XrefRangeEnd = 346385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VisualElementFocusChangeTarget __cctor_b__9_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeTarget.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_VisualElementFocusChangeTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElementFocusChangeTarget>(intPtr3) : null;
			}

			// Token: 0x06004093 RID: 16531 RVA: 0x0001B2EF File Offset: 0x000194EF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001354 RID: 4948
			// (get) Token: 0x06004094 RID: 16532 RVA: 0x001001A0 File Offset: 0x000FE3A0
			// (set) Token: 0x06004095 RID: 16533 RVA: 0x0001B2F8 File Offset: 0x000194F8
			public unsafe static VisualElementFocusChangeTarget.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisualElementFocusChangeTarget.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementFocusChangeTarget.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisualElementFocusChangeTarget.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D72 RID: 11634
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D73 RID: 11635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D74 RID: 11636
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__9_0_Internal_VisualElementFocusChangeTarget_0;
		}

		// Token: 0x0200052F RID: 1327
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
