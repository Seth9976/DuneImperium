using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011C RID: 284
	public sealed class ClickEvent : PointerEventBase<ClickEvent>
	{
		// Token: 0x060015C1 RID: 5569 RVA: 0x0006A2B8 File Offset: 0x000684B8
		// Note: this type is marked as 'beforefieldinit'.
		static ClickEvent()
		{
			Il2CppClassPointerStore<ClickEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ClickEvent");
			ClickEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr, 100666512);
			ClickEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr, 100666513);
			ClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr, 100666514);
			ClickEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_ClickEvent_PointerUpEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr, 100666515);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0006A330 File Offset: 0x00068530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316920, XrefRangeEnd = 316923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0006A364 File Offset: 0x00068564
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0006A398 File Offset: 0x00068598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316923, XrefRangeEnd = 316926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0006A3D4 File Offset: 0x000685D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316930, RefRangeEnd = 316931, XrefRangeStart = 316926, XrefRangeEnd = 316930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClickEvent GetPooled(PointerUpEvent pointerEvent, int clickCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clickCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_ClickEvent_PointerUpEvent_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClickEvent>(intPtr3) : null;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0000A220 File Offset: 0x00008420
		public ClickEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_ClickEvent_PointerUpEvent_Int32_0;

		// Token: 0x02000449 RID: 1097
		[ObfuscatedName("UnityEngine.UIElements.ClickEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B8B RID: 15243 RVA: 0x000EFE38 File Offset: 0x000EE038
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClickEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClickEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickEvent.__c>.NativeClassPtr);
				ClickEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickEvent.__c>.NativeClassPtr, "<>9");
				ClickEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEvent.__c>.NativeClassPtr, 100666517);
				ClickEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ClickEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickEvent.__c>.NativeClassPtr, 100666518);
			}

			// Token: 0x06003B8C RID: 15244 RVA: 0x000EFEA0 File Offset: 0x000EE0A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B8D RID: 15245 RVA: 0x000EFEDC File Offset: 0x000EE0DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316914, XrefRangeEnd = 316920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClickEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ClickEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClickEvent>(intPtr3) : null;
			}

			// Token: 0x06003B8E RID: 15246 RVA: 0x00019049 File Offset: 0x00017249
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001220 RID: 4640
			// (get) Token: 0x06003B8F RID: 15247 RVA: 0x000EFF1C File Offset: 0x000EE11C
			// (set) Token: 0x06003B90 RID: 15248 RVA: 0x00019052 File Offset: 0x00017252
			public unsafe static ClickEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClickEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClickEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClickEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A09 RID: 10761
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A0A RID: 10762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A0B RID: 10763
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_ClickEvent_0;
		}

		// Token: 0x0200044A RID: 1098
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
