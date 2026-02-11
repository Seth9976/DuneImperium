using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace worm.client.match.render.layout
{
	// Token: 0x020002A3 RID: 675
	public class ReverseChildIndexSorter : MonoBehaviour
	{
		// Token: 0x06001B63 RID: 7011 RVA: 0x0006C4B0 File Offset: 0x0006A6B0
		// Note: this type is marked as 'beforefieldinit'.
		static ReverseChildIndexSorter()
		{
			Il2CppClassPointerStore<ReverseChildIndexSorter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render.layout", "ReverseChildIndexSorter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReverseChildIndexSorter>.NativeClassPtr);
			ReverseChildIndexSorter.NativeMethodInfoPtr_SortViews_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverseChildIndexSorter>.NativeClassPtr, 100667288);
			ReverseChildIndexSorter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverseChildIndexSorter>.NativeClassPtr, 100667289);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0006C508 File Offset: 0x0006A708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724657, XrefRangeEnd = 724676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SortViews(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverseChildIndexSorter.NativeMethodInfoPtr_SortViews_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0006C54C File Offset: 0x0006A74C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReverseChildIndexSorter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverseChildIndexSorter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverseChildIndexSorter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0000FD3C File Offset: 0x0000DF3C
		public ReverseChildIndexSorter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_SortViews_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200043E RID: 1086
		[ObfuscatedName("worm.client.match.render.layout.ReverseChildIndexSorter+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002D2F RID: 11567 RVA: 0x000A1074 File Offset: 0x0009F274
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReverseChildIndexSorter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReverseChildIndexSorter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReverseChildIndexSorter.__c>.NativeClassPtr);
				ReverseChildIndexSorter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverseChildIndexSorter.__c>.NativeClassPtr, "<>9");
				ReverseChildIndexSorter.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverseChildIndexSorter.__c>.NativeClassPtr, "<>9__0_0");
				ReverseChildIndexSorter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverseChildIndexSorter.__c>.NativeClassPtr, 100667291);
				ReverseChildIndexSorter.__c.NativeMethodInfoPtr__SortViews_b__0_0_Internal_Int32_UnitView_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverseChildIndexSorter.__c>.NativeClassPtr, 100667292);
			}

			// Token: 0x06002D30 RID: 11568 RVA: 0x000A10F0 File Offset: 0x0009F2F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverseChildIndexSorter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverseChildIndexSorter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D31 RID: 11569 RVA: 0x000A112C File Offset: 0x0009F32C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724651, XrefRangeEnd = 724657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortViews_b__0_0(UnitView a, UnitView b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverseChildIndexSorter.__c.NativeMethodInfoPtr__SortViews_b__0_0_Internal_Int32_UnitView_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002D32 RID: 11570 RVA: 0x00018810 File Offset: 0x00016A10
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CFA RID: 3322
			// (get) Token: 0x06002D33 RID: 11571 RVA: 0x000A118C File Offset: 0x0009F38C
			// (set) Token: 0x06002D34 RID: 11572 RVA: 0x00018819 File Offset: 0x00016A19
			public unsafe static ReverseChildIndexSorter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverseChildIndexSorter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverseChildIndexSorter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverseChildIndexSorter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CFB RID: 3323
			// (get) Token: 0x06002D35 RID: 11573 RVA: 0x000A11B4 File Offset: 0x0009F3B4
			// (set) Token: 0x06002D36 RID: 11574 RVA: 0x0001882B File Offset: 0x00016A2B
			public unsafe static Comparison<UnitView> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReverseChildIndexSorter.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<UnitView>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReverseChildIndexSorter.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A48 RID: 6728
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001A49 RID: 6729
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001A4A RID: 6730
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A4B RID: 6731
			private static readonly IntPtr NativeMethodInfoPtr__SortViews_b__0_0_Internal_Int32_UnitView_UnitView_0;
		}
	}
}
