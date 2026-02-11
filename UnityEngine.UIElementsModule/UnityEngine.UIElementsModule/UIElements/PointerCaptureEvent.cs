using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C1 RID: 193
	public class PointerCaptureEvent : PointerCaptureEventBase<PointerCaptureEvent>
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x00008DAC File Offset: 0x00006FAC
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCaptureEvent()
		{
			Il2CppClassPointerStore<PointerCaptureEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCaptureEvent");
			PointerCaptureEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEvent>.NativeClassPtr, 100665782);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0005A9E8 File Offset: 0x00058BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311892, XrefRangeEnd = 311911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerCaptureEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCaptureEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00008DDB File Offset: 0x00006FDB
		public PointerCaptureEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003ED RID: 1005
		[ObfuscatedName("UnityEngine.UIElements.PointerCaptureEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003A93 RID: 14995 RVA: 0x000ED018 File Offset: 0x000EB218
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerCaptureEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerCaptureEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCaptureEvent.__c>.NativeClassPtr);
				PointerCaptureEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerCaptureEvent.__c>.NativeClassPtr, "<>9");
				PointerCaptureEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEvent.__c>.NativeClassPtr, 100665784);
				PointerCaptureEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerCaptureEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEvent.__c>.NativeClassPtr, 100665785);
			}

			// Token: 0x06003A94 RID: 14996 RVA: 0x000ED080 File Offset: 0x000EB280
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCaptureEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A95 RID: 14997 RVA: 0x000ED0BC File Offset: 0x000EB2BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311886, XrefRangeEnd = 311892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerCaptureEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerCaptureEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerCaptureEvent>(intPtr3) : null;
			}

			// Token: 0x06003A96 RID: 14998 RVA: 0x00018BF2 File Offset: 0x00016DF2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011F5 RID: 4597
			// (get) Token: 0x06003A97 RID: 14999 RVA: 0x000ED0FC File Offset: 0x000EB2FC
			// (set) Token: 0x06003A98 RID: 15000 RVA: 0x00018BFB File Offset: 0x00016DFB
			public unsafe static PointerCaptureEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerCaptureEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerCaptureEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerCaptureEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002963 RID: 10595
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002964 RID: 10596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002965 RID: 10597
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerCaptureEvent_0;
		}

		// Token: 0x020003EE RID: 1006
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
