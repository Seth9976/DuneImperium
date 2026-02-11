using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011F RID: 287
	public sealed class PointerOverEvent : PointerEventBase<PointerOverEvent>
	{
		// Token: 0x060015D1 RID: 5585 RVA: 0x0000A23B File Offset: 0x0000843B
		// Note: this type is marked as 'beforefieldinit'.
		static PointerOverEvent()
		{
			Il2CppClassPointerStore<PointerOverEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerOverEvent");
			PointerOverEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverEvent>.NativeClassPtr, 100666534);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0006A638 File Offset: 0x00068838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316961, XrefRangeEnd = 316964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerOverEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOverEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0000A26A File Offset: 0x0000846A
		public PointerOverEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200044F RID: 1103
		[ObfuscatedName("UnityEngine.UIElements.PointerOverEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B9D RID: 15261 RVA: 0x000F015C File Offset: 0x000EE35C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerOverEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerOverEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerOverEvent.__c>.NativeClassPtr);
				PointerOverEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerOverEvent.__c>.NativeClassPtr, "<>9");
				PointerOverEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverEvent.__c>.NativeClassPtr, 100666536);
				PointerOverEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOverEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOverEvent.__c>.NativeClassPtr, 100666537);
			}

			// Token: 0x06003B9E RID: 15262 RVA: 0x000F01C4 File Offset: 0x000EE3C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOverEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B9F RID: 15263 RVA: 0x000F0200 File Offset: 0x000EE400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316955, XrefRangeEnd = 316961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerOverEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOverEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOverEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerOverEvent>(intPtr3) : null;
			}

			// Token: 0x06003BA0 RID: 15264 RVA: 0x0001909A File Offset: 0x0001729A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001223 RID: 4643
			// (get) Token: 0x06003BA1 RID: 15265 RVA: 0x000F0240 File Offset: 0x000EE440
			// (set) Token: 0x06003BA2 RID: 15266 RVA: 0x000190A3 File Offset: 0x000172A3
			public unsafe static PointerOverEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerOverEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerOverEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerOverEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A12 RID: 10770
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A13 RID: 10771
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A14 RID: 10772
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOverEvent_0;
		}

		// Token: 0x02000450 RID: 1104
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
