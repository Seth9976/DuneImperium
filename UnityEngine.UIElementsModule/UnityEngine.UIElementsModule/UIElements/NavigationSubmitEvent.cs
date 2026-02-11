using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010A RID: 266
	public class NavigationSubmitEvent : NavigationEventBase<NavigationSubmitEvent>
	{
		// Token: 0x060014AD RID: 5293 RVA: 0x00009CB9 File Offset: 0x00007EB9
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationSubmitEvent()
		{
			Il2CppClassPointerStore<NavigationSubmitEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigationSubmitEvent");
			NavigationSubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationSubmitEvent>.NativeClassPtr, 100666317);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00066278 File Offset: 0x00064478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315566, XrefRangeEnd = 315569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationSubmitEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationSubmitEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationSubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00009CE8 File Offset: 0x00007EE8
		public NavigationSubmitEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000437 RID: 1079
		[ObfuscatedName("UnityEngine.UIElements.NavigationSubmitEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B4B RID: 15179 RVA: 0x000EF270 File Offset: 0x000ED470
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NavigationSubmitEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationSubmitEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationSubmitEvent.__c>.NativeClassPtr);
				NavigationSubmitEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSubmitEvent.__c>.NativeClassPtr, "<>9");
				NavigationSubmitEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationSubmitEvent.__c>.NativeClassPtr, 100666319);
				NavigationSubmitEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_NavigationSubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationSubmitEvent.__c>.NativeClassPtr, 100666320);
			}

			// Token: 0x06003B4C RID: 15180 RVA: 0x000EF2D8 File Offset: 0x000ED4D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationSubmitEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationSubmitEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B4D RID: 15181 RVA: 0x000EF314 File Offset: 0x000ED514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315560, XrefRangeEnd = 315566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationSubmitEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationSubmitEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_NavigationSubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationSubmitEvent>(intPtr3) : null;
			}

			// Token: 0x06003B4E RID: 15182 RVA: 0x00018F01 File Offset: 0x00017101
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001212 RID: 4626
			// (get) Token: 0x06003B4F RID: 15183 RVA: 0x000EF354 File Offset: 0x000ED554
			// (set) Token: 0x06003B50 RID: 15184 RVA: 0x00018F0A File Offset: 0x0001710A
			public unsafe static NavigationSubmitEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationSubmitEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationSubmitEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationSubmitEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029E4 RID: 10724
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029E5 RID: 10725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029E6 RID: 10726
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_NavigationSubmitEvent_0;
		}

		// Token: 0x02000438 RID: 1080
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
