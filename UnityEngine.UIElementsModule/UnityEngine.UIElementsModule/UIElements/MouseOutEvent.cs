using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000100 RID: 256
	public class MouseOutEvent : MouseEventBase<MouseOutEvent>
	{
		// Token: 0x0600145E RID: 5214 RVA: 0x00009B31 File Offset: 0x00007D31
		// Note: this type is marked as 'beforefieldinit'.
		static MouseOutEvent()
		{
			Il2CppClassPointerStore<MouseOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseOutEvent");
			MouseOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseOutEvent>.NativeClassPtr, 100666259);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00064FC8 File Offset: 0x000631C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315145, XrefRangeEnd = 315164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00009B60 File Offset: 0x00007D60
		public MouseOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200042C RID: 1068
		[ObfuscatedName("UnityEngine.UIElements.MouseOutEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B31 RID: 15153 RVA: 0x000EED78 File Offset: 0x000ECF78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MouseOutEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseOutEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseOutEvent.__c>.NativeClassPtr);
				MouseOutEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseOutEvent.__c>.NativeClassPtr, "<>9");
				MouseOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseOutEvent.__c>.NativeClassPtr, 100666261);
				MouseOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseOutEvent.__c>.NativeClassPtr, 100666262);
			}

			// Token: 0x06003B32 RID: 15154 RVA: 0x000EEDE0 File Offset: 0x000ECFE0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseOutEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B33 RID: 15155 RVA: 0x000EEE1C File Offset: 0x000ED01C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315139, XrefRangeEnd = 315145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseOutEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseOutEvent>(intPtr3) : null;
			}

			// Token: 0x06003B34 RID: 15156 RVA: 0x00018E95 File Offset: 0x00017095
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700120E RID: 4622
			// (get) Token: 0x06003B35 RID: 15157 RVA: 0x000EEE5C File Offset: 0x000ED05C
			// (set) Token: 0x06003B36 RID: 15158 RVA: 0x00018E9E File Offset: 0x0001709E
			public unsafe static MouseOutEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MouseOutEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseOutEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MouseOutEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029CE RID: 10702
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029CF RID: 10703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029D0 RID: 10704
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_MouseOutEvent_0;
		}

		// Token: 0x0200042D RID: 1069
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
