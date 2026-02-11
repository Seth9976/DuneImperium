using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000120 RID: 288
	public sealed class PointerOutEvent : PointerEventBase<PointerOutEvent>
	{
		// Token: 0x060015D4 RID: 5588 RVA: 0x0000A273 File Offset: 0x00008473
		// Note: this type is marked as 'beforefieldinit'.
		static PointerOutEvent()
		{
			Il2CppClassPointerStore<PointerOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerOutEvent");
			PointerOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutEvent>.NativeClassPtr, 100666539);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0006A674 File Offset: 0x00068874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316970, XrefRangeEnd = 316989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0000A2A2 File Offset: 0x000084A2
		public PointerOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000451 RID: 1105
		[ObfuscatedName("UnityEngine.UIElements.PointerOutEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003BA3 RID: 15267 RVA: 0x000F0268 File Offset: 0x000EE468
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerOutEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerOutEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerOutEvent.__c>.NativeClassPtr);
				PointerOutEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerOutEvent.__c>.NativeClassPtr, "<>9");
				PointerOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutEvent.__c>.NativeClassPtr, 100666541);
				PointerOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutEvent.__c>.NativeClassPtr, 100666542);
			}

			// Token: 0x06003BA4 RID: 15268 RVA: 0x000F02D0 File Offset: 0x000EE4D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOutEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BA5 RID: 15269 RVA: 0x000F030C File Offset: 0x000EE50C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316964, XrefRangeEnd = 316970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerOutEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerOutEvent>(intPtr3) : null;
			}

			// Token: 0x06003BA6 RID: 15270 RVA: 0x000190B5 File Offset: 0x000172B5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001224 RID: 4644
			// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x000F034C File Offset: 0x000EE54C
			// (set) Token: 0x06003BA8 RID: 15272 RVA: 0x000190BE File Offset: 0x000172BE
			public unsafe static PointerOutEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerOutEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerOutEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerOutEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A15 RID: 10773
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A16 RID: 10774
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A17 RID: 10775
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerOutEvent_0;
		}

		// Token: 0x02000452 RID: 1106
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
