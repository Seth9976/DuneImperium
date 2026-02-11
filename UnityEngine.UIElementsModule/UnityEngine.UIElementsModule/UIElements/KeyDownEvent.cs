using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000ED RID: 237
	public class KeyDownEvent : KeyboardEventBase<KeyDownEvent>
	{
		// Token: 0x0600139B RID: 5019 RVA: 0x00061EC0 File Offset: 0x000600C0
		// Note: this type is marked as 'beforefieldinit'.
		static KeyDownEvent()
		{
			Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyDownEvent");
			KeyDownEvent.NativeMethodInfoPtr_GetEquivalentImguiEvent_Internal_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr, 100666084);
			KeyDownEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr, 100666085);
			KeyDownEvent.NativeMethodInfoPtr_SendEquivalentNavigationEventIfAny_Private_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr, 100666086);
			KeyDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr, 100666087);
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00061F38 File Offset: 0x00060138
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314244, RefRangeEnd = 314247, XrefRangeStart = 314239, XrefRangeEnd = 314244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetEquivalentImguiEvent(Event outImguiEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outImguiEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyDownEvent.NativeMethodInfoPtr_GetEquivalentImguiEvent_Internal_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00061F7C File Offset: 0x0006017C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314247, XrefRangeEnd = 314253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyDownEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00061FCC File Offset: 0x000601CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314338, RefRangeEnd = 314339, XrefRangeStart = 314253, XrefRangeEnd = 314338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEquivalentNavigationEventIfAny(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyDownEvent.NativeMethodInfoPtr_SendEquivalentNavigationEventIfAny_Private_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00062010 File Offset: 0x00060210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314339, XrefRangeEnd = 314358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyDownEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0000987B File Offset: 0x00007A7B
		public KeyDownEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_GetEquivalentImguiEvent_Internal_Void_Event_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_SendEquivalentNavigationEventIfAny_Private_Void_IPanel_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000411 RID: 1041
		[ObfuscatedName("UnityEngine.UIElements.KeyDownEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AE3 RID: 15075 RVA: 0x000EDFDC File Offset: 0x000EC1DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KeyDownEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyDownEvent.__c>.NativeClassPtr);
				KeyDownEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyDownEvent.__c>.NativeClassPtr, "<>9");
				KeyDownEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyDownEvent.__c>.NativeClassPtr, 100666089);
				KeyDownEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_KeyDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyDownEvent.__c>.NativeClassPtr, 100666090);
			}

			// Token: 0x06003AE4 RID: 15076 RVA: 0x000EE044 File Offset: 0x000EC244
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyDownEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyDownEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AE5 RID: 15077 RVA: 0x000EE080 File Offset: 0x000EC280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314233, XrefRangeEnd = 314239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyDownEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyDownEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_KeyDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyDownEvent>(intPtr3) : null;
			}

			// Token: 0x06003AE6 RID: 15078 RVA: 0x00018D36 File Offset: 0x00016F36
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001201 RID: 4609
			// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x000EE0C0 File Offset: 0x000EC2C0
			// (set) Token: 0x06003AE8 RID: 15080 RVA: 0x00018D3F File Offset: 0x00016F3F
			public unsafe static KeyDownEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KeyDownEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyDownEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KeyDownEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029A3 RID: 10659
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029A4 RID: 10660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029A5 RID: 10661
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_KeyDownEvent_0;
		}

		// Token: 0x02000412 RID: 1042
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
