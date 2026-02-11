using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000128 RID: 296
	public sealed class TransitionEndEvent : TransitionEventBase<TransitionEndEvent>
	{
		// Token: 0x06001619 RID: 5657 RVA: 0x0000A49F File Offset: 0x0000869F
		// Note: this type is marked as 'beforefieldinit'.
		static TransitionEndEvent()
		{
			Il2CppClassPointerStore<TransitionEndEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TransitionEndEvent");
			TransitionEndEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionEndEvent>.NativeClassPtr, 100666592);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0006B278 File Offset: 0x00069478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317298, XrefRangeEnd = 317317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionEndEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionEndEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionEndEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0000A4CE File Offset: 0x000086CE
		public TransitionEndEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200045F RID: 1119
		[ObfuscatedName("UnityEngine.UIElements.TransitionEndEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003BD2 RID: 15314 RVA: 0x000F0B24 File Offset: 0x000EED24
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TransitionEndEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionEndEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionEndEvent.__c>.NativeClassPtr);
				TransitionEndEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionEndEvent.__c>.NativeClassPtr, "<>9");
				TransitionEndEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionEndEvent.__c>.NativeClassPtr, 100666594);
				TransitionEndEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionEndEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionEndEvent.__c>.NativeClassPtr, 100666595);
			}

			// Token: 0x06003BD3 RID: 15315 RVA: 0x000F0B8C File Offset: 0x000EED8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionEndEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionEndEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BD4 RID: 15316 RVA: 0x000F0BC8 File Offset: 0x000EEDC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317292, XrefRangeEnd = 317298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TransitionEndEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionEndEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionEndEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransitionEndEvent>(intPtr3) : null;
			}

			// Token: 0x06003BD5 RID: 15317 RVA: 0x000191A0 File Offset: 0x000173A0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700122D RID: 4653
			// (get) Token: 0x06003BD6 RID: 15318 RVA: 0x000F0C08 File Offset: 0x000EEE08
			// (set) Token: 0x06003BD7 RID: 15319 RVA: 0x000191A9 File Offset: 0x000173A9
			public unsafe static TransitionEndEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TransitionEndEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitionEndEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TransitionEndEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A32 RID: 10802
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A33 RID: 10803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A34 RID: 10804
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionEndEvent_0;
		}

		// Token: 0x02000460 RID: 1120
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
