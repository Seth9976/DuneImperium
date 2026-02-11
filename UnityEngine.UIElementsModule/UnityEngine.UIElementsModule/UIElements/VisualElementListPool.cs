using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000221 RID: 545
	public static class VisualElementListPool : Object
	{
		// Token: 0x0600290B RID: 10507 RVA: 0x000B3D24 File Offset: 0x000B1F24
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementListPool()
		{
			Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementListPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr);
			VisualElementListPool.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr, "pool");
			VisualElementListPool.NativeMethodInfoPtr_Copy_Public_Static_List_1_VisualElement_List_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr, 100669463);
			VisualElementListPool.NativeMethodInfoPtr_Get_Public_Static_List_1_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr, 100669464);
			VisualElementListPool.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr, 100669465);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000B3DA4 File Offset: 0x000B1FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346077, RefRangeEnd = 346078, XrefRangeStart = 346067, XrefRangeEnd = 346077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<VisualElement> Copy(List<VisualElement> elements)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementListPool.NativeMethodInfoPtr_Copy_Public_Static_List_1_VisualElement_List_1_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr3) : null;
			}
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000B3DE8 File Offset: 0x000B1FE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 346091, RefRangeEnd = 346096, XrefRangeStart = 346078, XrefRangeEnd = 346091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<VisualElement> Get(int initialCapacity = 0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementListPool.NativeMethodInfoPtr_Get_Public_Static_List_1_VisualElement_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr3) : null;
			}
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000B3E28 File Offset: 0x000B2028
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 346126, RefRangeEnd = 346133, XrefRangeStart = 346096, XrefRangeEnd = 346126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(List<VisualElement> elements)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementListPool.NativeMethodInfoPtr_Release_Public_Static_Void_List_1_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x0001092D File Offset: 0x0000EB2D
		public VisualElementListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x000B3E60 File Offset: 0x000B2060
		// (set) Token: 0x06002911 RID: 10513 RVA: 0x00010936 File Offset: 0x0000EB36
		public unsafe static ObjectPool<List<VisualElement>> pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementListPool.NativeFieldInfoPtr_pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<List<VisualElement>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementListPool.NativeFieldInfoPtr_pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeFieldInfoPtr_pool;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_List_1_VisualElement_List_1_VisualElement_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_List_1_VisualElement_Int32_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_List_1_VisualElement_0;

		// Token: 0x0200052A RID: 1322
		[ObfuscatedName("UnityEngine.UIElements.VisualElementListPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004082 RID: 16514 RVA: 0x000FFE14 File Offset: 0x000FE014
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VisualElementListPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualElementListPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementListPool.__c>.NativeClassPtr);
				VisualElementListPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementListPool.__c>.NativeClassPtr, "<>9");
				VisualElementListPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementListPool.__c>.NativeClassPtr, 100669468);
				VisualElementListPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_List_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementListPool.__c>.NativeClassPtr, 100669469);
			}

			// Token: 0x06004083 RID: 16515 RVA: 0x000FFE7C File Offset: 0x000FE07C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementListPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementListPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004084 RID: 16516 RVA: 0x000FFEB8 File Offset: 0x000FE0B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346061, XrefRangeEnd = 346067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<VisualElement> __cctor_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementListPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_List_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr3) : null;
			}

			// Token: 0x06004085 RID: 16517 RVA: 0x0001B2A7 File Offset: 0x000194A7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001352 RID: 4946
			// (get) Token: 0x06004086 RID: 16518 RVA: 0x000FFEF8 File Offset: 0x000FE0F8
			// (set) Token: 0x06004087 RID: 16519 RVA: 0x0001B2B0 File Offset: 0x000194B0
			public unsafe static VisualElementListPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisualElementListPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementListPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisualElementListPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D68 RID: 11624
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D69 RID: 11625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D6A RID: 11626
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_List_1_VisualElement_0;
		}

		// Token: 0x0200052B RID: 1323
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
