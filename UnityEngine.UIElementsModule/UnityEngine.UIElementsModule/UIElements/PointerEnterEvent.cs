using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011D RID: 285
	public sealed class PointerEnterEvent : PointerEventBase<PointerEnterEvent>
	{
		// Token: 0x060015C7 RID: 5575 RVA: 0x0006A428 File Offset: 0x00068628
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEnterEvent()
		{
			Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerEnterEvent");
			PointerEnterEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr, 100666520);
			PointerEnterEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr, 100666521);
			PointerEnterEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr, 100666522);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0006A48C File Offset: 0x0006868C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316937, XrefRangeEnd = 316940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEnterEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0006A4C0 File Offset: 0x000686C0
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEnterEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0006A4F4 File Offset: 0x000686F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316940, XrefRangeEnd = 316943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEnterEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEnterEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0000A229 File Offset: 0x00008429
		public PointerEnterEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200044B RID: 1099
		[ObfuscatedName("UnityEngine.UIElements.PointerEnterEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003B91 RID: 15249 RVA: 0x000EFF44 File Offset: 0x000EE144
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PointerEnterEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerEnterEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEnterEvent.__c>.NativeClassPtr);
				PointerEnterEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEnterEvent.__c>.NativeClassPtr, "<>9");
				PointerEnterEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEnterEvent.__c>.NativeClassPtr, 100666524);
				PointerEnterEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerEnterEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEnterEvent.__c>.NativeClassPtr, 100666525);
			}

			// Token: 0x06003B92 RID: 15250 RVA: 0x000EFFAC File Offset: 0x000EE1AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEnterEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEnterEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B93 RID: 15251 RVA: 0x000EFFE8 File Offset: 0x000EE1E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316931, XrefRangeEnd = 316937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerEnterEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEnterEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerEnterEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEnterEvent>(intPtr3) : null;
			}

			// Token: 0x06003B94 RID: 15252 RVA: 0x00019064 File Offset: 0x00017264
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001221 RID: 4641
			// (get) Token: 0x06003B95 RID: 15253 RVA: 0x000F0028 File Offset: 0x000EE228
			// (set) Token: 0x06003B96 RID: 15254 RVA: 0x0001906D File Offset: 0x0001726D
			public unsafe static PointerEnterEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PointerEnterEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEnterEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PointerEnterEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A0C RID: 10764
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A0D RID: 10765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A0E RID: 10766
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_PointerEnterEvent_0;
		}

		// Token: 0x0200044C RID: 1100
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
