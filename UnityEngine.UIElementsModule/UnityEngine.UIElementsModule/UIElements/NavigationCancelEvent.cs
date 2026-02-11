using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000109 RID: 265
	public class NavigationCancelEvent : NavigationEventBase<NavigationCancelEvent>
	{
		// Token: 0x060014AA RID: 5290 RVA: 0x00009C81 File Offset: 0x00007E81
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationCancelEvent()
		{
			Il2CppClassPointerStore<NavigationCancelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigationCancelEvent");
			NavigationCancelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationCancelEvent>.NativeClassPtr, 100666312);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0006623C File Offset: 0x0006443C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315557, XrefRangeEnd = 315560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationCancelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationCancelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationCancelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00009CB0 File Offset: 0x00007EB0
		public NavigationCancelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000435 RID: 1077
		[ObfuscatedName("UnityEngine.UIElements.NavigationCancelEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B45 RID: 15173 RVA: 0x000EF164 File Offset: 0x000ED364
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NavigationCancelEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationCancelEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationCancelEvent.__c>.NativeClassPtr);
				NavigationCancelEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationCancelEvent.__c>.NativeClassPtr, "<>9");
				NavigationCancelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationCancelEvent.__c>.NativeClassPtr, 100666314);
				NavigationCancelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_NavigationCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationCancelEvent.__c>.NativeClassPtr, 100666315);
			}

			// Token: 0x06003B46 RID: 15174 RVA: 0x000EF1CC File Offset: 0x000ED3CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationCancelEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationCancelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B47 RID: 15175 RVA: 0x000EF208 File Offset: 0x000ED408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315551, XrefRangeEnd = 315557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationCancelEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationCancelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_NavigationCancelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationCancelEvent>(intPtr3) : null;
			}

			// Token: 0x06003B48 RID: 15176 RVA: 0x00018EE6 File Offset: 0x000170E6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001211 RID: 4625
			// (get) Token: 0x06003B49 RID: 15177 RVA: 0x000EF248 File Offset: 0x000ED448
			// (set) Token: 0x06003B4A RID: 15178 RVA: 0x00018EEF File Offset: 0x000170EF
			public unsafe static NavigationCancelEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationCancelEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationCancelEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationCancelEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029E1 RID: 10721
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029E2 RID: 10722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029E3 RID: 10723
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_NavigationCancelEvent_0;
		}

		// Token: 0x02000436 RID: 1078
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
