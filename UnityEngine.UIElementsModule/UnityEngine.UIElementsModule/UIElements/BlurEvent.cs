using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E2 RID: 226
	public class BlurEvent : FocusEventBase<BlurEvent>
	{
		// Token: 0x0600134E RID: 4942 RVA: 0x00060CA0 File Offset: 0x0005EEA0
		// Note: this type is marked as 'beforefieldinit'.
		static BlurEvent()
		{
			Il2CppClassPointerStore<BlurEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BlurEvent");
			BlurEvent.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlurEvent>.NativeClassPtr, 100666024);
			BlurEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlurEvent>.NativeClassPtr, 100666025);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00060CF0 File Offset: 0x0005EEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313904, XrefRangeEnd = 313907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlurEvent.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00060D40 File Offset: 0x0005EF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313907, XrefRangeEnd = 313910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlurEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlurEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlurEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00009782 File Offset: 0x00007982
		public BlurEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000409 RID: 1033
		[ObfuscatedName("UnityEngine.UIElements.BlurEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003ACB RID: 15051 RVA: 0x000EDBAC File Offset: 0x000EBDAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BlurEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlurEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlurEvent.__c>.NativeClassPtr);
				BlurEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlurEvent.__c>.NativeClassPtr, "<>9");
				BlurEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlurEvent.__c>.NativeClassPtr, 100666027);
				BlurEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_BlurEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlurEvent.__c>.NativeClassPtr, 100666028);
			}

			// Token: 0x06003ACC RID: 15052 RVA: 0x000EDC14 File Offset: 0x000EBE14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlurEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlurEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003ACD RID: 15053 RVA: 0x000EDC50 File Offset: 0x000EBE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313898, XrefRangeEnd = 313904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BlurEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlurEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_BlurEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlurEvent>(intPtr3) : null;
			}

			// Token: 0x06003ACE RID: 15054 RVA: 0x00018CCA File Offset: 0x00016ECA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011FD RID: 4605
			// (get) Token: 0x06003ACF RID: 15055 RVA: 0x000EDC90 File Offset: 0x000EBE90
			// (set) Token: 0x06003AD0 RID: 15056 RVA: 0x00018CD3 File Offset: 0x00016ED3
			public unsafe static BlurEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BlurEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlurEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BlurEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002997 RID: 10647
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002998 RID: 10648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002999 RID: 10649
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_BlurEvent_0;
		}

		// Token: 0x0200040A RID: 1034
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
