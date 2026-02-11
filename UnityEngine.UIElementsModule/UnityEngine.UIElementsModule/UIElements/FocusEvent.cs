using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E4 RID: 228
	public class FocusEvent : FocusEventBase<FocusEvent>
	{
		// Token: 0x06001357 RID: 4951 RVA: 0x00060E8C File Offset: 0x0005F08C
		// Note: this type is marked as 'beforefieldinit'.
		static FocusEvent()
		{
			Il2CppClassPointerStore<FocusEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusEvent");
			FocusEvent.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEvent>.NativeClassPtr, 100666037);
			FocusEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEvent>.NativeClassPtr, 100666038);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00060EDC File Offset: 0x0005F0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313928, XrefRangeEnd = 313951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusEvent.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00060F2C File Offset: 0x0005F12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313951, XrefRangeEnd = 313954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00009794 File Offset: 0x00007994
		public FocusEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200040D RID: 1037
		[ObfuscatedName("UnityEngine.UIElements.FocusEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AD7 RID: 15063 RVA: 0x000EDDC4 File Offset: 0x000EBFC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FocusEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FocusEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusEvent.__c>.NativeClassPtr);
				FocusEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusEvent.__c>.NativeClassPtr, "<>9");
				FocusEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEvent.__c>.NativeClassPtr, 100666040);
				FocusEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_FocusEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEvent.__c>.NativeClassPtr, 100666041);
			}

			// Token: 0x06003AD8 RID: 15064 RVA: 0x000EDE2C File Offset: 0x000EC02C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AD9 RID: 15065 RVA: 0x000EDE68 File Offset: 0x000EC068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313922, XrefRangeEnd = 313928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FocusEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_FocusEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusEvent>(intPtr3) : null;
			}

			// Token: 0x06003ADA RID: 15066 RVA: 0x00018D00 File Offset: 0x00016F00
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011FF RID: 4607
			// (get) Token: 0x06003ADB RID: 15067 RVA: 0x000EDEA8 File Offset: 0x000EC0A8
			// (set) Token: 0x06003ADC RID: 15068 RVA: 0x00018D09 File Offset: 0x00016F09
			public unsafe static FocusEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FocusEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FocusEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400299D RID: 10653
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400299E RID: 10654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400299F RID: 10655
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_FocusEvent_0;
		}

		// Token: 0x0200040E RID: 1038
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
