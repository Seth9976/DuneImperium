using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000126 RID: 294
	public sealed class TransitionRunEvent : TransitionEventBase<TransitionRunEvent>
	{
		// Token: 0x06001613 RID: 5651 RVA: 0x0000A42F File Offset: 0x0000862F
		// Note: this type is marked as 'beforefieldinit'.
		static TransitionRunEvent()
		{
			Il2CppClassPointerStore<TransitionRunEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TransitionRunEvent");
			TransitionRunEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionRunEvent>.NativeClassPtr, 100666582);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x0006B200 File Offset: 0x00069400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317264, XrefRangeEnd = 317283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionRunEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionRunEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionRunEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x0000A45E File Offset: 0x0000865E
		public TransitionRunEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200045B RID: 1115
		[ObfuscatedName("UnityEngine.UIElements.TransitionRunEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003BC6 RID: 15302 RVA: 0x000F090C File Offset: 0x000EEB0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TransitionRunEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionRunEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionRunEvent.__c>.NativeClassPtr);
				TransitionRunEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionRunEvent.__c>.NativeClassPtr, "<>9");
				TransitionRunEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionRunEvent.__c>.NativeClassPtr, 100666584);
				TransitionRunEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionRunEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionRunEvent.__c>.NativeClassPtr, 100666585);
			}

			// Token: 0x06003BC7 RID: 15303 RVA: 0x000F0974 File Offset: 0x000EEB74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionRunEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionRunEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BC8 RID: 15304 RVA: 0x000F09B0 File Offset: 0x000EEBB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317258, XrefRangeEnd = 317264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TransitionRunEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionRunEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionRunEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransitionRunEvent>(intPtr3) : null;
			}

			// Token: 0x06003BC9 RID: 15305 RVA: 0x0001916A File Offset: 0x0001736A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700122B RID: 4651
			// (get) Token: 0x06003BCA RID: 15306 RVA: 0x000F09F0 File Offset: 0x000EEBF0
			// (set) Token: 0x06003BCB RID: 15307 RVA: 0x00019173 File Offset: 0x00017373
			public unsafe static TransitionRunEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TransitionRunEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitionRunEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TransitionRunEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A2C RID: 10796
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A2D RID: 10797
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A2E RID: 10798
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionRunEvent_0;
		}

		// Token: 0x0200045C RID: 1116
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
