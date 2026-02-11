using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000121 RID: 289
	public class PropagationPaths : Object
	{
		// Token: 0x060015D7 RID: 5591 RVA: 0x0006A6B0 File Offset: 0x000688B0
		// Note: this type is marked as 'beforefieldinit'.
		static PropagationPaths()
		{
			Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PropagationPaths");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr);
			PropagationPaths.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "s_Pool");
			PropagationPaths.NativeFieldInfoPtr_trickleDownPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "trickleDownPath");
			PropagationPaths.NativeFieldInfoPtr_targetElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "targetElements");
			PropagationPaths.NativeFieldInfoPtr_bubbleUpPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "bubbleUpPath");
			PropagationPaths.NativeFieldInfoPtr_k_DefaultPropagationDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "k_DefaultPropagationDepth");
			PropagationPaths.NativeFieldInfoPtr_k_DefaultTargetCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "k_DefaultTargetCount");
			PropagationPaths.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, 100666543);
			PropagationPaths.NativeMethodInfoPtr_Build_Public_Static_PropagationPaths_VisualElement_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, 100666544);
			PropagationPaths.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, 100666545);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x0006A794 File Offset: 0x00068994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317010, XrefRangeEnd = 317028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropagationPaths()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagationPaths.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x0006A7D0 File Offset: 0x000689D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317054, RefRangeEnd = 317056, XrefRangeStart = 317028, XrefRangeEnd = 317054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropagationPaths Build(VisualElement elem, EventBase evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagationPaths.NativeMethodInfoPtr_Build_Public_Static_PropagationPaths_VisualElement_EventBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropagationPaths>(intPtr3) : null;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x0006A828 File Offset: 0x00068A28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317088, RefRangeEnd = 317089, XrefRangeStart = 317056, XrefRangeEnd = 317088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagationPaths.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0000A2AB File Offset: 0x000084AB
		public PropagationPaths(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x0006A85C File Offset: 0x00068A5C
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x0000A2B4 File Offset: 0x000084B4
		public unsafe static ObjectPool<PropagationPaths> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PropagationPaths.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<PropagationPaths>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropagationPaths.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x0006A884 File Offset: 0x00068A84
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x0000A2C6 File Offset: 0x000084C6
		public unsafe List<VisualElement> trickleDownPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_trickleDownPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_trickleDownPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x0006A8B4 File Offset: 0x00068AB4
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x0000A2E5 File Offset: 0x000084E5
		public unsafe List<VisualElement> targetElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_targetElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_targetElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x0006A8E4 File Offset: 0x00068AE4
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x0000A304 File Offset: 0x00008504
		public unsafe List<VisualElement> bubbleUpPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_bubbleUpPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_bubbleUpPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0006A914 File Offset: 0x00068B14
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x0000A323 File Offset: 0x00008523
		public unsafe static int k_DefaultPropagationDepth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PropagationPaths.NativeFieldInfoPtr_k_DefaultPropagationDepth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropagationPaths.NativeFieldInfoPtr_k_DefaultPropagationDepth, (void*)(&value));
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x0006A930 File Offset: 0x00068B30
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x0000A331 File Offset: 0x00008531
		public unsafe static int k_DefaultTargetCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PropagationPaths.NativeFieldInfoPtr_k_DefaultTargetCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropagationPaths.NativeFieldInfoPtr_k_DefaultTargetCount, (void*)(&value));
			}
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0006A94C File Offset: 0x00068B4C
		public static PropagationPaths Copy(PropagationPaths paths)
		{
			PropagationPaths propagationPaths = PropagationPaths.s_Pool.Get();
			propagationPaths.trickleDownPath.AddRange(paths.trickleDownPath);
			propagationPaths.targetElements.AddRange(paths.targetElements);
			propagationPaths.bubbleUpPath.AddRange(paths.bubbleUpPath);
			return propagationPaths;
		}

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeFieldInfoPtr_trickleDownPath;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeFieldInfoPtr_targetElements;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeFieldInfoPtr_bubbleUpPath;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultPropagationDepth;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultTargetCount;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Static_PropagationPaths_VisualElement_EventBase_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x02000453 RID: 1107
		[ObfuscatedName("UnityEngine.UIElements.PropagationPaths+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003BA9 RID: 15273 RVA: 0x000F0374 File Offset: 0x000EE574
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PropagationPaths.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropagationPaths.__c>.NativeClassPtr);
				PropagationPaths.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths.__c>.NativeClassPtr, "<>9");
				PropagationPaths.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagationPaths.__c>.NativeClassPtr, 100666548);
				PropagationPaths.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_PropagationPaths_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagationPaths.__c>.NativeClassPtr, 100666549);
			}

			// Token: 0x06003BAA RID: 15274 RVA: 0x000F03DC File Offset: 0x000EE5DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropagationPaths.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagationPaths.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BAB RID: 15275 RVA: 0x000F0418 File Offset: 0x000EE618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316989, XrefRangeEnd = 317010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropagationPaths __cctor_b__12_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagationPaths.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_PropagationPaths_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropagationPaths>(intPtr3) : null;
			}

			// Token: 0x06003BAC RID: 15276 RVA: 0x000190D0 File Offset: 0x000172D0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001225 RID: 4645
			// (get) Token: 0x06003BAD RID: 15277 RVA: 0x000F0458 File Offset: 0x000EE658
			// (set) Token: 0x06003BAE RID: 15278 RVA: 0x000190D9 File Offset: 0x000172D9
			public unsafe static PropagationPaths.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropagationPaths.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropagationPaths.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropagationPaths.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A18 RID: 10776
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A19 RID: 10777
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A1A RID: 10778
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__12_0_Internal_PropagationPaths_0;
		}

		// Token: 0x02000454 RID: 1108
		public enum Type
		{
			// Token: 0x04002A1C RID: 10780
			None,
			// Token: 0x04002A1D RID: 10781
			TrickleDown,
			// Token: 0x04002A1E RID: 10782
			BubbleUp
		}

		// Token: 0x02000455 RID: 1109
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
