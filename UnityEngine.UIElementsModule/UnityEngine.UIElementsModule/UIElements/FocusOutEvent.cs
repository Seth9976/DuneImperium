using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E1 RID: 225
	public class FocusOutEvent : FocusEventBase<FocusOutEvent>
	{
		// Token: 0x06001349 RID: 4937 RVA: 0x00060B90 File Offset: 0x0005ED90
		// Note: this type is marked as 'beforefieldinit'.
		static FocusOutEvent()
		{
			Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusOutEvent");
			FocusOutEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr, 100666017);
			FocusOutEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr, 100666018);
			FocusOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr, 100666019);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00060BF4 File Offset: 0x0005EDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313892, XrefRangeEnd = 313895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusOutEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00060C30 File Offset: 0x0005EE30
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusOutEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00060C64 File Offset: 0x0005EE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313895, XrefRangeEnd = 313898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00009779 File Offset: 0x00007979
		public FocusOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000407 RID: 1031
		[ObfuscatedName("UnityEngine.UIElements.FocusOutEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AC5 RID: 15045 RVA: 0x000EDAA0 File Offset: 0x000EBCA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FocusOutEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FocusOutEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusOutEvent.__c>.NativeClassPtr);
				FocusOutEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusOutEvent.__c>.NativeClassPtr, "<>9");
				FocusOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusOutEvent.__c>.NativeClassPtr, 100666021);
				FocusOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_FocusOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusOutEvent.__c>.NativeClassPtr, 100666022);
			}

			// Token: 0x06003AC6 RID: 15046 RVA: 0x000EDB08 File Offset: 0x000EBD08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusOutEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusOutEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AC7 RID: 15047 RVA: 0x000EDB44 File Offset: 0x000EBD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313886, XrefRangeEnd = 313892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FocusOutEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusOutEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_FocusOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusOutEvent>(intPtr3) : null;
			}

			// Token: 0x06003AC8 RID: 15048 RVA: 0x00018CAF File Offset: 0x00016EAF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011FC RID: 4604
			// (get) Token: 0x06003AC9 RID: 15049 RVA: 0x000EDB84 File Offset: 0x000EBD84
			// (set) Token: 0x06003ACA RID: 15050 RVA: 0x00018CB8 File Offset: 0x00016EB8
			public unsafe static FocusOutEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FocusOutEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusOutEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FocusOutEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002994 RID: 10644
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002995 RID: 10645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002996 RID: 10646
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_FocusOutEvent_0;
		}

		// Token: 0x02000408 RID: 1032
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
