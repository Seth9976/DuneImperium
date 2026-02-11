using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010C RID: 268
	public class AttachToPanelEvent : PanelChangedEventBase<AttachToPanelEvent>
	{
		// Token: 0x060014BE RID: 5310 RVA: 0x00009D38 File Offset: 0x00007F38
		// Note: this type is marked as 'beforefieldinit'.
		static AttachToPanelEvent()
		{
			Il2CppClassPointerStore<AttachToPanelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "AttachToPanelEvent");
			AttachToPanelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachToPanelEvent>.NativeClassPtr, 100666330);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0006664C File Offset: 0x0006484C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315601, XrefRangeEnd = 315604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttachToPanelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttachToPanelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachToPanelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00009D67 File Offset: 0x00007F67
		public AttachToPanelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000439 RID: 1081
		[ObfuscatedName("UnityEngine.UIElements.AttachToPanelEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B51 RID: 15185 RVA: 0x000EF37C File Offset: 0x000ED57C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AttachToPanelEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttachToPanelEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachToPanelEvent.__c>.NativeClassPtr);
				AttachToPanelEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachToPanelEvent.__c>.NativeClassPtr, "<>9");
				AttachToPanelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachToPanelEvent.__c>.NativeClassPtr, 100666332);
				AttachToPanelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachToPanelEvent.__c>.NativeClassPtr, 100666333);
			}

			// Token: 0x06003B52 RID: 15186 RVA: 0x000EF3E4 File Offset: 0x000ED5E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttachToPanelEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachToPanelEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B53 RID: 15187 RVA: 0x000EF420 File Offset: 0x000ED620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315595, XrefRangeEnd = 315601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttachToPanelEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachToPanelEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttachToPanelEvent>(intPtr3) : null;
			}

			// Token: 0x06003B54 RID: 15188 RVA: 0x00018F1C File Offset: 0x0001711C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001213 RID: 4627
			// (get) Token: 0x06003B55 RID: 15189 RVA: 0x000EF460 File Offset: 0x000ED660
			// (set) Token: 0x06003B56 RID: 15190 RVA: 0x00018F25 File Offset: 0x00017125
			public unsafe static AttachToPanelEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttachToPanelEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttachToPanelEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttachToPanelEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029E7 RID: 10727
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029E8 RID: 10728
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029E9 RID: 10729
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_AttachToPanelEvent_0;
		}

		// Token: 0x0200043A RID: 1082
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
