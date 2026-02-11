using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F9 RID: 249
	public class ContextClickEvent : MouseEventBase<ContextClickEvent>
	{
		// Token: 0x06001435 RID: 5173 RVA: 0x00009A79 File Offset: 0x00007C79
		// Note: this type is marked as 'beforefieldinit'.
		static ContextClickEvent()
		{
			Il2CppClassPointerStore<ContextClickEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ContextClickEvent");
			ContextClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextClickEvent>.NativeClassPtr, 100666206);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000646D0 File Offset: 0x000628D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314954, XrefRangeEnd = 314957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextClickEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextClickEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00009AA8 File Offset: 0x00007CA8
		public ContextClickEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200041E RID: 1054
		[ObfuscatedName("UnityEngine.UIElements.ContextClickEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B07 RID: 15111 RVA: 0x000EE624 File Offset: 0x000EC824
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ContextClickEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContextClickEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextClickEvent.__c>.NativeClassPtr);
				ContextClickEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextClickEvent.__c>.NativeClassPtr, "<>9");
				ContextClickEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextClickEvent.__c>.NativeClassPtr, 100666208);
				ContextClickEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ContextClickEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextClickEvent.__c>.NativeClassPtr, 100666209);
			}

			// Token: 0x06003B08 RID: 15112 RVA: 0x000EE68C File Offset: 0x000EC88C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextClickEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextClickEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B09 RID: 15113 RVA: 0x000EE6C8 File Offset: 0x000EC8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314948, XrefRangeEnd = 314954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContextClickEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextClickEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ContextClickEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextClickEvent>(intPtr3) : null;
			}

			// Token: 0x06003B0A RID: 15114 RVA: 0x00018DD8 File Offset: 0x00016FD8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001207 RID: 4615
			// (get) Token: 0x06003B0B RID: 15115 RVA: 0x000EE708 File Offset: 0x000EC908
			// (set) Token: 0x06003B0C RID: 15116 RVA: 0x00018DE1 File Offset: 0x00016FE1
			public unsafe static ContextClickEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContextClickEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextClickEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContextClickEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029B9 RID: 10681
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029BA RID: 10682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029BB RID: 10683
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_ContextClickEvent_0;
		}

		// Token: 0x0200041F RID: 1055
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
