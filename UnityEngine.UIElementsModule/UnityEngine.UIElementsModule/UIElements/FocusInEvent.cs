using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E3 RID: 227
	public class FocusInEvent : FocusEventBase<FocusInEvent>
	{
		// Token: 0x06001352 RID: 4946 RVA: 0x00060D7C File Offset: 0x0005EF7C
		// Note: this type is marked as 'beforefieldinit'.
		static FocusInEvent()
		{
			Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusInEvent");
			FocusInEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr, 100666030);
			FocusInEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr, 100666031);
			FocusInEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr, 100666032);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00060DE0 File Offset: 0x0005EFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313916, XrefRangeEnd = 313919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusInEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00060E1C File Offset: 0x0005F01C
		[CallerCount(0)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusInEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00060E50 File Offset: 0x0005F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313919, XrefRangeEnd = 313922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusInEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusInEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0000978B File Offset: 0x0000798B
		public FocusInEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200040B RID: 1035
		[ObfuscatedName("UnityEngine.UIElements.FocusInEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AD1 RID: 15057 RVA: 0x000EDCB8 File Offset: 0x000EBEB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FocusInEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FocusInEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusInEvent.__c>.NativeClassPtr);
				FocusInEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusInEvent.__c>.NativeClassPtr, "<>9");
				FocusInEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusInEvent.__c>.NativeClassPtr, 100666034);
				FocusInEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_FocusInEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusInEvent.__c>.NativeClassPtr, 100666035);
			}

			// Token: 0x06003AD2 RID: 15058 RVA: 0x000EDD20 File Offset: 0x000EBF20
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusInEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusInEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AD3 RID: 15059 RVA: 0x000EDD5C File Offset: 0x000EBF5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313910, XrefRangeEnd = 313916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FocusInEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusInEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_FocusInEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusInEvent>(intPtr3) : null;
			}

			// Token: 0x06003AD4 RID: 15060 RVA: 0x00018CE5 File Offset: 0x00016EE5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011FE RID: 4606
			// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x000EDD9C File Offset: 0x000EBF9C
			// (set) Token: 0x06003AD6 RID: 15062 RVA: 0x00018CEE File Offset: 0x00016EEE
			public unsafe static FocusInEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FocusInEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusInEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FocusInEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400299A RID: 10650
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400299B RID: 10651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400299C RID: 10652
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_FocusInEvent_0;
		}

		// Token: 0x0200040C RID: 1036
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
