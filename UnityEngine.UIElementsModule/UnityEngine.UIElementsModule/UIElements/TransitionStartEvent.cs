using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000127 RID: 295
	public sealed class TransitionStartEvent : TransitionEventBase<TransitionStartEvent>
	{
		// Token: 0x06001616 RID: 5654 RVA: 0x0000A467 File Offset: 0x00008667
		// Note: this type is marked as 'beforefieldinit'.
		static TransitionStartEvent()
		{
			Il2CppClassPointerStore<TransitionStartEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TransitionStartEvent");
			TransitionStartEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionStartEvent>.NativeClassPtr, 100666587);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0006B23C File Offset: 0x0006943C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317289, XrefRangeEnd = 317292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionStartEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionStartEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionStartEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0000A496 File Offset: 0x00008696
		public TransitionStartEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200045D RID: 1117
		[ObfuscatedName("UnityEngine.UIElements.TransitionStartEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003BCC RID: 15308 RVA: 0x000F0A18 File Offset: 0x000EEC18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TransitionStartEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitionStartEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionStartEvent.__c>.NativeClassPtr);
				TransitionStartEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionStartEvent.__c>.NativeClassPtr, "<>9");
				TransitionStartEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionStartEvent.__c>.NativeClassPtr, 100666589);
				TransitionStartEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionStartEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionStartEvent.__c>.NativeClassPtr, 100666590);
			}

			// Token: 0x06003BCD RID: 15309 RVA: 0x000F0A80 File Offset: 0x000EEC80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionStartEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionStartEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BCE RID: 15310 RVA: 0x000F0ABC File Offset: 0x000EECBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317283, XrefRangeEnd = 317289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TransitionStartEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionStartEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionStartEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransitionStartEvent>(intPtr3) : null;
			}

			// Token: 0x06003BCF RID: 15311 RVA: 0x00019185 File Offset: 0x00017385
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700122C RID: 4652
			// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x000F0AFC File Offset: 0x000EECFC
			// (set) Token: 0x06003BD1 RID: 15313 RVA: 0x0001918E File Offset: 0x0001738E
			public unsafe static TransitionStartEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TransitionStartEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitionStartEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TransitionStartEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A2F RID: 10799
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A30 RID: 10800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A31 RID: 10801
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_TransitionStartEvent_0;
		}

		// Token: 0x0200045E RID: 1118
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
