using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000122 RID: 290
	public class CustomStyleResolvedEvent : EventBase<CustomStyleResolvedEvent>
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x0006A9A0 File Offset: 0x00068BA0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomStyleResolvedEvent()
		{
			Il2CppClassPointerStore<CustomStyleResolvedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CustomStyleResolvedEvent");
			CustomStyleResolvedEvent.NativeMethodInfoPtr_get_customStyle_Public_get_ICustomStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleResolvedEvent>.NativeClassPtr, 100666551);
			CustomStyleResolvedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleResolvedEvent>.NativeClassPtr, 100666552);
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x0006A9F0 File Offset: 0x00068BF0
		public unsafe ICustomStyle customStyle
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 317103, RefRangeEnd = 317111, XrefRangeStart = 317098, XrefRangeEnd = 317103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleResolvedEvent.NativeMethodInfoPtr_get_customStyle_Public_get_ICustomStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomStyle>(intPtr3) : null;
			}
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0006AA30 File Offset: 0x00068C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317111, XrefRangeEnd = 317117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomStyleResolvedEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomStyleResolvedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleResolvedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0000A33F File Offset: 0x0000853F
		public CustomStyleResolvedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_get_customStyle_Public_get_ICustomStyle_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000456 RID: 1110
		[ObfuscatedName("UnityEngine.UIElements.CustomStyleResolvedEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003BAF RID: 15279 RVA: 0x000F0480 File Offset: 0x000EE680
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CustomStyleResolvedEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomStyleResolvedEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomStyleResolvedEvent.__c>.NativeClassPtr);
				CustomStyleResolvedEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomStyleResolvedEvent.__c>.NativeClassPtr, "<>9");
				CustomStyleResolvedEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleResolvedEvent.__c>.NativeClassPtr, 100666554);
				CustomStyleResolvedEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_CustomStyleResolvedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomStyleResolvedEvent.__c>.NativeClassPtr, 100666555);
			}

			// Token: 0x06003BB0 RID: 15280 RVA: 0x000F04E8 File Offset: 0x000EE6E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomStyleResolvedEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleResolvedEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BB1 RID: 15281 RVA: 0x000F0524 File Offset: 0x000EE724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317089, XrefRangeEnd = 317098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomStyleResolvedEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomStyleResolvedEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_CustomStyleResolvedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomStyleResolvedEvent>(intPtr3) : null;
			}

			// Token: 0x06003BB2 RID: 15282 RVA: 0x000190EB File Offset: 0x000172EB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001226 RID: 4646
			// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x000F0564 File Offset: 0x000EE764
			// (set) Token: 0x06003BB4 RID: 15284 RVA: 0x000190F4 File Offset: 0x000172F4
			public unsafe static CustomStyleResolvedEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomStyleResolvedEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomStyleResolvedEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomStyleResolvedEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A1F RID: 10783
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A20 RID: 10784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A21 RID: 10785
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_CustomStyleResolvedEvent_0;
		}

		// Token: 0x02000457 RID: 1111
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
