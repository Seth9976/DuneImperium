using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FF RID: 255
	public class MouseOverEvent : MouseEventBase<MouseOverEvent>
	{
		// Token: 0x0600145B RID: 5211 RVA: 0x00009AF9 File Offset: 0x00007CF9
		// Note: this type is marked as 'beforefieldinit'.
		static MouseOverEvent()
		{
			Il2CppClassPointerStore<MouseOverEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseOverEvent");
			MouseOverEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseOverEvent>.NativeClassPtr, 100666254);
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00064F8C File Offset: 0x0006318C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315136, XrefRangeEnd = 315139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseOverEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseOverEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseOverEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00009B28 File Offset: 0x00007D28
		public MouseOverEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200042A RID: 1066
		[ObfuscatedName("UnityEngine.UIElements.MouseOverEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B2B RID: 15147 RVA: 0x000EEC6C File Offset: 0x000ECE6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MouseOverEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseOverEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseOverEvent.__c>.NativeClassPtr);
				MouseOverEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseOverEvent.__c>.NativeClassPtr, "<>9");
				MouseOverEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseOverEvent.__c>.NativeClassPtr, 100666256);
				MouseOverEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseOverEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseOverEvent.__c>.NativeClassPtr, 100666257);
			}

			// Token: 0x06003B2C RID: 15148 RVA: 0x000EECD4 File Offset: 0x000ECED4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseOverEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseOverEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B2D RID: 15149 RVA: 0x000EED10 File Offset: 0x000ECF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315130, XrefRangeEnd = 315136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseOverEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseOverEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseOverEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseOverEvent>(intPtr3) : null;
			}

			// Token: 0x06003B2E RID: 15150 RVA: 0x00018E7A File Offset: 0x0001707A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700120D RID: 4621
			// (get) Token: 0x06003B2F RID: 15151 RVA: 0x000EED50 File Offset: 0x000ECF50
			// (set) Token: 0x06003B30 RID: 15152 RVA: 0x00018E83 File Offset: 0x00017083
			public unsafe static MouseOverEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MouseOverEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseOverEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MouseOverEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029CB RID: 10699
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029CC RID: 10700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029CD RID: 10701
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseOverEvent_0;
		}

		// Token: 0x0200042B RID: 1067
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
