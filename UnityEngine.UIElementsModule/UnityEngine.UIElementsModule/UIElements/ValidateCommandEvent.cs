using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C9 RID: 201
	public class ValidateCommandEvent : CommandEventBase<ValidateCommandEvent>
	{
		// Token: 0x060011D2 RID: 4562 RVA: 0x00008EC3 File Offset: 0x000070C3
		// Note: this type is marked as 'beforefieldinit'.
		static ValidateCommandEvent()
		{
			Il2CppClassPointerStore<ValidateCommandEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ValidateCommandEvent");
			ValidateCommandEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateCommandEvent>.NativeClassPtr, 100665821);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0005B590 File Offset: 0x00059790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312032, XrefRangeEnd = 312035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidateCommandEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidateCommandEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateCommandEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00008EF2 File Offset: 0x000070F2
		public ValidateCommandEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F4 RID: 1012
		[ObfuscatedName("UnityEngine.UIElements.ValidateCommandEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AAB RID: 15019 RVA: 0x000ED484 File Offset: 0x000EB684
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValidateCommandEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidateCommandEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateCommandEvent.__c>.NativeClassPtr);
				ValidateCommandEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateCommandEvent.__c>.NativeClassPtr, "<>9");
				ValidateCommandEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateCommandEvent.__c>.NativeClassPtr, 100665823);
				ValidateCommandEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ValidateCommandEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateCommandEvent.__c>.NativeClassPtr, 100665824);
			}

			// Token: 0x06003AAC RID: 15020 RVA: 0x000ED4EC File Offset: 0x000EB6EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidateCommandEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateCommandEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AAD RID: 15021 RVA: 0x000ED528 File Offset: 0x000EB728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312026, XrefRangeEnd = 312032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidateCommandEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateCommandEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ValidateCommandEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidateCommandEvent>(intPtr3) : null;
			}

			// Token: 0x06003AAE RID: 15022 RVA: 0x00018C5E File Offset: 0x00016E5E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011F9 RID: 4601
			// (get) Token: 0x06003AAF RID: 15023 RVA: 0x000ED568 File Offset: 0x000EB768
			// (set) Token: 0x06003AB0 RID: 15024 RVA: 0x00018C67 File Offset: 0x00016E67
			public unsafe static ValidateCommandEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValidateCommandEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidateCommandEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValidateCommandEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400296F RID: 10607
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002970 RID: 10608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002971 RID: 10609
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_ValidateCommandEvent_0;
		}

		// Token: 0x020003F5 RID: 1013
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
