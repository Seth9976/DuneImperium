using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C0 RID: 192
	public class PointerCaptureOutEvent : PointerCaptureEventBase<PointerCaptureOutEvent>
	{
		// Token: 0x060011A0 RID: 4512 RVA: 0x00008D74 File Offset: 0x00006F74
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCaptureOutEvent()
		{
			Il2CppClassPointerStore<PointerCaptureOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCaptureOutEvent");
			PointerCaptureOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureOutEvent>.NativeClassPtr, 100665777);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0005A9AC File Offset: 0x00058BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311883, XrefRangeEnd = 311886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerCaptureOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCaptureOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00008DA3 File Offset: 0x00006FA3
		public PointerCaptureOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003EB RID: 1003
		[ObfuscatedName("UnityEngine.UIElements.PointerCaptureOutEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003A8D RID: 14989 RVA: 0x000ECF0C File Offset: 0x000EB10C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerCaptureOutEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerCaptureOutEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCaptureOutEvent.__c>.NativeClassPtr);
				PointerCaptureOutEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerCaptureOutEvent.__c>.NativeClassPtr, "<>9");
				PointerCaptureOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureOutEvent.__c>.NativeClassPtr, 100665779);
				PointerCaptureOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerCaptureOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureOutEvent.__c>.NativeClassPtr, 100665780);
			}

			// Token: 0x06003A8E RID: 14990 RVA: 0x000ECF74 File Offset: 0x000EB174
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCaptureOutEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A8F RID: 14991 RVA: 0x000ECFB0 File Offset: 0x000EB1B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311877, XrefRangeEnd = 311883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerCaptureOutEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerCaptureOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerCaptureOutEvent>(intPtr3) : null;
			}

			// Token: 0x06003A90 RID: 14992 RVA: 0x00018BD7 File Offset: 0x00016DD7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011F4 RID: 4596
			// (get) Token: 0x06003A91 RID: 14993 RVA: 0x000ECFF0 File Offset: 0x000EB1F0
			// (set) Token: 0x06003A92 RID: 14994 RVA: 0x00018BE0 File Offset: 0x00016DE0
			public unsafe static PointerCaptureOutEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerCaptureOutEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerCaptureOutEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerCaptureOutEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002960 RID: 10592
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002961 RID: 10593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002962 RID: 10594
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerCaptureOutEvent_0;
		}

		// Token: 0x020003EC RID: 1004
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
