using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CA RID: 202
	public class ExecuteCommandEvent : CommandEventBase<ExecuteCommandEvent>
	{
		// Token: 0x060011D5 RID: 4565 RVA: 0x00008EFB File Offset: 0x000070FB
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteCommandEvent()
		{
			Il2CppClassPointerStore<ExecuteCommandEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ExecuteCommandEvent");
			ExecuteCommandEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteCommandEvent>.NativeClassPtr, 100665826);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0005B5CC File Offset: 0x000597CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312041, XrefRangeEnd = 312044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteCommandEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteCommandEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteCommandEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00008F2A File Offset: 0x0000712A
		public ExecuteCommandEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F6 RID: 1014
		[ObfuscatedName("UnityEngine.UIElements.ExecuteCommandEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003AB1 RID: 15025 RVA: 0x000ED590 File Offset: 0x000EB790
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ExecuteCommandEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteCommandEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteCommandEvent.__c>.NativeClassPtr);
				ExecuteCommandEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteCommandEvent.__c>.NativeClassPtr, "<>9");
				ExecuteCommandEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteCommandEvent.__c>.NativeClassPtr, 100665828);
				ExecuteCommandEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ExecuteCommandEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteCommandEvent.__c>.NativeClassPtr, 100665829);
			}

			// Token: 0x06003AB2 RID: 15026 RVA: 0x000ED5F8 File Offset: 0x000EB7F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteCommandEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteCommandEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003AB3 RID: 15027 RVA: 0x000ED634 File Offset: 0x000EB834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312035, XrefRangeEnd = 312041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExecuteCommandEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteCommandEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_ExecuteCommandEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteCommandEvent>(intPtr3) : null;
			}

			// Token: 0x06003AB4 RID: 15028 RVA: 0x00018C79 File Offset: 0x00016E79
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011FA RID: 4602
			// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x000ED674 File Offset: 0x000EB874
			// (set) Token: 0x06003AB6 RID: 15030 RVA: 0x00018C82 File Offset: 0x00016E82
			public unsafe static ExecuteCommandEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExecuteCommandEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteCommandEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExecuteCommandEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002972 RID: 10610
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002973 RID: 10611
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002974 RID: 10612
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_ExecuteCommandEvent_0;
		}

		// Token: 0x020003F7 RID: 1015
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
