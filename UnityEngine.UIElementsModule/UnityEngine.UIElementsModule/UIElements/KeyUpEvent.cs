using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EF RID: 239
	public class KeyUpEvent : KeyboardEventBase<KeyUpEvent>
	{
		// Token: 0x060013A5 RID: 5029 RVA: 0x0000988D File Offset: 0x00007A8D
		// Note: this type is marked as 'beforefieldinit'.
		static KeyUpEvent()
		{
			Il2CppClassPointerStore<KeyUpEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyUpEvent");
			KeyUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyUpEvent>.NativeClassPtr, 100666094);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0006212C File Offset: 0x0006032C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314383, XrefRangeEnd = 314386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyUpEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyUpEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x000098BC File Offset: 0x00007ABC
		public KeyUpEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000413 RID: 1043
		[ObfuscatedName("UnityEngine.UIElements.KeyUpEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AE9 RID: 15081 RVA: 0x000EE0E8 File Offset: 0x000EC2E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KeyUpEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyUpEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyUpEvent.__c>.NativeClassPtr);
				KeyUpEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyUpEvent.__c>.NativeClassPtr, "<>9");
				KeyUpEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyUpEvent.__c>.NativeClassPtr, 100666096);
				KeyUpEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_KeyUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyUpEvent.__c>.NativeClassPtr, 100666097);
			}

			// Token: 0x06003AEA RID: 15082 RVA: 0x000EE150 File Offset: 0x000EC350
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyUpEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyUpEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AEB RID: 15083 RVA: 0x000EE18C File Offset: 0x000EC38C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314377, XrefRangeEnd = 314383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyUpEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyUpEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_KeyUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyUpEvent>(intPtr3) : null;
			}

			// Token: 0x06003AEC RID: 15084 RVA: 0x00018D51 File Offset: 0x00016F51
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001202 RID: 4610
			// (get) Token: 0x06003AED RID: 15085 RVA: 0x000EE1CC File Offset: 0x000EC3CC
			// (set) Token: 0x06003AEE RID: 15086 RVA: 0x00018D5A File Offset: 0x00016F5A
			public unsafe static KeyUpEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KeyUpEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyUpEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KeyUpEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029A6 RID: 10662
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029A7 RID: 10663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029A8 RID: 10664
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_KeyUpEvent_0;
		}

		// Token: 0x02000414 RID: 1044
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
