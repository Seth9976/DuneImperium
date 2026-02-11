using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000129 RID: 297
	public sealed class TransitionCancelEvent : TransitionEventBase<TransitionCancelEvent>
	{
		// Token: 0x0600161C RID: 5660 RVA: 0x0000A4D7 File Offset: 0x000086D7
		// Note: this type is marked as 'beforefieldinit'.
		static TransitionCancelEvent()
		{
			Il2CppClassPointerStore<TransitionCancelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TransitionCancelEvent");
			TransitionCancelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionCancelEvent>.NativeClassPtr, 100666597);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0006B2B4 File Offset: 0x000694B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317323, XrefRangeEnd = 317342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionCancelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionCancelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionCancelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0000A506 File Offset: 0x00008706
		public TransitionCancelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000461 RID: 1121
		[ObfuscatedName("UnityEngine.UIElements.TransitionCancelEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003BD8 RID: 15320 RVA: 0x000F0C30 File Offset: 0x000EEE30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TransitionCancelEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionCancelEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionCancelEvent.__c>.NativeClassPtr);
				TransitionCancelEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionCancelEvent.__c>.NativeClassPtr, "<>9");
				TransitionCancelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionCancelEvent.__c>.NativeClassPtr, 100666599);
				TransitionCancelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionCancelEvent.__c>.NativeClassPtr, 100666600);
			}

			// Token: 0x06003BD9 RID: 15321 RVA: 0x000F0C98 File Offset: 0x000EEE98
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionCancelEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionCancelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BDA RID: 15322 RVA: 0x000F0CD4 File Offset: 0x000EEED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317317, XrefRangeEnd = 317323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TransitionCancelEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionCancelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionCancelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransitionCancelEvent>(intPtr3) : null;
			}

			// Token: 0x06003BDB RID: 15323 RVA: 0x000191BB File Offset: 0x000173BB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700122E RID: 4654
			// (get) Token: 0x06003BDC RID: 15324 RVA: 0x000F0D14 File Offset: 0x000EEF14
			// (set) Token: 0x06003BDD RID: 15325 RVA: 0x000191C4 File Offset: 0x000173C4
			public unsafe static TransitionCancelEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TransitionCancelEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitionCancelEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TransitionCancelEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A35 RID: 10805
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A36 RID: 10806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A37 RID: 10807
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionCancelEvent_0;
		}

		// Token: 0x02000462 RID: 1122
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
