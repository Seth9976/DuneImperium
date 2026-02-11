using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010D RID: 269
	public class DetachFromPanelEvent : PanelChangedEventBase<DetachFromPanelEvent>
	{
		// Token: 0x060014C1 RID: 5313 RVA: 0x00009D70 File Offset: 0x00007F70
		// Note: this type is marked as 'beforefieldinit'.
		static DetachFromPanelEvent()
		{
			Il2CppClassPointerStore<DetachFromPanelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DetachFromPanelEvent");
			DetachFromPanelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachFromPanelEvent>.NativeClassPtr, 100666335);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00066688 File Offset: 0x00064888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315610, XrefRangeEnd = 315613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DetachFromPanelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetachFromPanelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachFromPanelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00009D9F File Offset: 0x00007F9F
		public DetachFromPanelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200043B RID: 1083
		[ObfuscatedName("UnityEngine.UIElements.DetachFromPanelEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B57 RID: 15191 RVA: 0x000EF488 File Offset: 0x000ED688
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DetachFromPanelEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DetachFromPanelEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetachFromPanelEvent.__c>.NativeClassPtr);
				DetachFromPanelEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetachFromPanelEvent.__c>.NativeClassPtr, "<>9");
				DetachFromPanelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachFromPanelEvent.__c>.NativeClassPtr, 100666337);
				DetachFromPanelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetachFromPanelEvent.__c>.NativeClassPtr, 100666338);
			}

			// Token: 0x06003B58 RID: 15192 RVA: 0x000EF4F0 File Offset: 0x000ED6F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetachFromPanelEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachFromPanelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B59 RID: 15193 RVA: 0x000EF52C File Offset: 0x000ED72C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315604, XrefRangeEnd = 315610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DetachFromPanelEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetachFromPanelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DetachFromPanelEvent>(intPtr3) : null;
			}

			// Token: 0x06003B5A RID: 15194 RVA: 0x00018F37 File Offset: 0x00017137
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001214 RID: 4628
			// (get) Token: 0x06003B5B RID: 15195 RVA: 0x000EF56C File Offset: 0x000ED76C
			// (set) Token: 0x06003B5C RID: 15196 RVA: 0x00018F40 File Offset: 0x00017140
			public unsafe static DetachFromPanelEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DetachFromPanelEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DetachFromPanelEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DetachFromPanelEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029EA RID: 10730
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029EB RID: 10731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029EC RID: 10732
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_DetachFromPanelEvent_0;
		}

		// Token: 0x0200043C RID: 1084
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
