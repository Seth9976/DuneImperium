using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using voodoo.flavors;

namespace boardgames.match.voodoo
{
	// Token: 0x0200024A RID: 586
	public class FlavoredLayout : MonoBehaviour
	{
		// Token: 0x06001A90 RID: 6800 RVA: 0x00074248 File Offset: 0x00072448
		// Note: this type is marked as 'beforefieldinit'.
		static FlavoredLayout()
		{
			Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.voodoo", "FlavoredLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr);
			FlavoredLayout.NativeFieldInfoPtr_flavoredContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, "flavoredContainers");
			FlavoredLayout.NativeFieldInfoPtr_disablePileOnEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, "disablePileOnEmpty");
			FlavoredLayout.NativeFieldInfoPtr_sortedContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, "sortedContainers");
			FlavoredLayout.NativeMethodInfoPtr_get_SortedContainers_Protected_get_List_1_Container_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, 100667536);
			FlavoredLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, 100667537);
			FlavoredLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, 100667538);
			FlavoredLayout.NativeMethodInfoPtr_TryGetContainerFor_Protected_Boolean_UnitView_byref_Container_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, 100667539);
			FlavoredLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, 100667540);
			FlavoredLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, 100667541);
			FlavoredLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, 100667542);
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x00074340 File Offset: 0x00072540
		public unsafe List<FlavoredLayout.Container> SortedContainers
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 532378, RefRangeEnd = 532381, XrefRangeStart = 532339, XrefRangeEnd = 532378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.NativeMethodInfoPtr_get_SortedContainers_Protected_get_List_1_Container_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FlavoredLayout.Container>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00074380 File Offset: 0x00072580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532381, XrefRangeEnd = 532412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000743C4 File Offset: 0x000725C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532412, XrefRangeEnd = 532418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform GetSlotFor(UnitView view, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00074424 File Offset: 0x00072624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 532432, RefRangeEnd = 532433, XrefRangeStart = 532418, XrefRangeEnd = 532432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetContainerFor(UnitView view, out FlavoredLayout.Container container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.NativeMethodInfoPtr_TryGetContainerFor_Protected_Boolean_UnitView_byref_Container_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			container = ((intPtr4 == 0) ? null : new FlavoredLayout.Container(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00074494 File Offset: 0x00072694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532433, XrefRangeEnd = 532468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnViewsRemoved(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x000744D8 File Offset: 0x000726D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532468, XrefRangeEnd = 532487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0007450C File Offset: 0x0007270C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532487, XrefRangeEnd = 532492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0000E835 File Offset: 0x0000CA35
		public FlavoredLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00074548 File Offset: 0x00072748
		// (set) Token: 0x06001A9A RID: 6810 RVA: 0x0000E83E File Offset: 0x0000CA3E
		public unsafe Il2CppReferenceArray<PileFlavors> flavoredContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.NativeFieldInfoPtr_flavoredContainers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PileFlavors>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.NativeFieldInfoPtr_flavoredContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x00074578 File Offset: 0x00072778
		// (set) Token: 0x06001A9C RID: 6812 RVA: 0x0000E85D File Offset: 0x0000CA5D
		public unsafe bool disablePileOnEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.NativeFieldInfoPtr_disablePileOnEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.NativeFieldInfoPtr_disablePileOnEmpty)) = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x000745A0 File Offset: 0x000727A0
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x0000E878 File Offset: 0x0000CA78
		public unsafe List<FlavoredLayout.Container> sortedContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.NativeFieldInfoPtr_sortedContainers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FlavoredLayout.Container>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.NativeFieldInfoPtr_sortedContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeFieldInfoPtr_flavoredContainers;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeFieldInfoPtr_disablePileOnEmpty;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeFieldInfoPtr_sortedContainers;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_get_SortedContainers_Protected_get_List_1_Container_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_TryGetContainerFor_Protected_Boolean_UnitView_byref_Container_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200043B RID: 1083
		public sealed class Container : ValueType
		{
			// Token: 0x06003330 RID: 13104 RVA: 0x000C1434 File Offset: 0x000BF634
			// Note: this type is marked as 'beforefieldinit'.
			static Container()
			{
				Il2CppClassPointerStore<FlavoredLayout.Container>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, "Container");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredLayout.Container>.NativeClassPtr);
				FlavoredLayout.Container.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout.Container>.NativeClassPtr, "flavors");
				FlavoredLayout.Container.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout.Container>.NativeClassPtr, "layout");
				FlavoredLayout.Container.NativeFieldInfoPtr_sorter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout.Container>.NativeClassPtr, "sorter");
				FlavoredLayout.Container.NativeFieldInfoPtr_views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout.Container>.NativeClassPtr, "views");
				FlavoredLayout.Container.NativeMethodInfoPtr__ctor_Public_Void_PileFlavors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout.Container>.NativeClassPtr, 100667543);
			}

			// Token: 0x06003331 RID: 13105 RVA: 0x000C14C4 File Offset: 0x000BF6C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 532336, RefRangeEnd = 532337, XrefRangeStart = 532319, XrefRangeEnd = 532336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Container(PileFlavors flavors)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredLayout.Container>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.Container.NativeMethodInfoPtr__ctor_Public_Void_PileFlavors_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003332 RID: 13106 RVA: 0x0001A6D5 File Offset: 0x000188D5
			public Container(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003333 RID: 13107 RVA: 0x0001A6DE File Offset: 0x000188DE
			public Container()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredLayout.Container>.NativeClassPtr))
			{
			}

			// Token: 0x17000EED RID: 3821
			// (get) Token: 0x06003334 RID: 13108 RVA: 0x000C1514 File Offset: 0x000BF714
			// (set) Token: 0x06003335 RID: 13109 RVA: 0x0001A6F0 File Offset: 0x000188F0
			public unsafe PileFlavors flavors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.Container.NativeFieldInfoPtr_flavors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PileFlavors>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.Container.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EEE RID: 3822
			// (get) Token: 0x06003336 RID: 13110 RVA: 0x000C1544 File Offset: 0x000BF744
			// (set) Token: 0x06003337 RID: 13111 RVA: 0x0001A70F File Offset: 0x0001890F
			public unsafe IViewLayout layout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.Container.NativeFieldInfoPtr_layout);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IViewLayout>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.Container.NativeFieldInfoPtr_layout), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EEF RID: 3823
			// (get) Token: 0x06003338 RID: 13112 RVA: 0x000C1574 File Offset: 0x000BF774
			// (set) Token: 0x06003339 RID: 13113 RVA: 0x0001A72E File Offset: 0x0001892E
			public unsafe IViewSorter sorter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.Container.NativeFieldInfoPtr_sorter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IViewSorter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.Container.NativeFieldInfoPtr_sorter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF0 RID: 3824
			// (get) Token: 0x0600333A RID: 13114 RVA: 0x000C15A4 File Offset: 0x000BF7A4
			// (set) Token: 0x0600333B RID: 13115 RVA: 0x0001A74D File Offset: 0x0001894D
			public unsafe List<UnitView> views
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.Container.NativeFieldInfoPtr_views);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredLayout.Container.NativeFieldInfoPtr_views), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F95 RID: 8085
			private static readonly IntPtr NativeFieldInfoPtr_flavors;

			// Token: 0x04001F96 RID: 8086
			private static readonly IntPtr NativeFieldInfoPtr_layout;

			// Token: 0x04001F97 RID: 8087
			private static readonly IntPtr NativeFieldInfoPtr_sorter;

			// Token: 0x04001F98 RID: 8088
			private static readonly IntPtr NativeFieldInfoPtr_views;

			// Token: 0x04001F99 RID: 8089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PileFlavors_0;
		}

		// Token: 0x0200043C RID: 1084
		[ObfuscatedName("boardgames.match.voodoo.FlavoredLayout+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600333C RID: 13116 RVA: 0x000C15D4 File Offset: 0x000BF7D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FlavoredLayout.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlavoredLayout>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredLayout.__c>.NativeClassPtr);
				FlavoredLayout.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout.__c>.NativeClassPtr, "<>9");
				FlavoredLayout.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout.__c>.NativeClassPtr, "<>9__5_0");
				FlavoredLayout.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredLayout.__c>.NativeClassPtr, "<>9__5_1");
				FlavoredLayout.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout.__c>.NativeClassPtr, 100667545);
				FlavoredLayout.__c.NativeMethodInfoPtr__get_SortedContainers_b__5_0_Internal_Int32_PileFlavors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout.__c>.NativeClassPtr, 100667546);
				FlavoredLayout.__c.NativeMethodInfoPtr__get_SortedContainers_b__5_1_Internal_Container_PileFlavors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredLayout.__c>.NativeClassPtr, 100667547);
			}

			// Token: 0x0600333D RID: 13117 RVA: 0x000C1678 File Offset: 0x000BF878
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredLayout.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600333E RID: 13118 RVA: 0x000C16B4 File Offset: 0x000BF8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532337, XrefRangeEnd = 532338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_SortedContainers_b__5_0(PileFlavors c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.__c.NativeMethodInfoPtr__get_SortedContainers_b__5_0_Internal_Int32_PileFlavors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600333F RID: 13119 RVA: 0x000C1704 File Offset: 0x000BF904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532338, XrefRangeEnd = 532339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FlavoredLayout.Container _get_SortedContainers_b__5_1(PileFlavors c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredLayout.__c.NativeMethodInfoPtr__get_SortedContainers_b__5_1_Internal_Container_PileFlavors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new FlavoredLayout.Container(intPtr);
				}
			}

			// Token: 0x06003340 RID: 13120 RVA: 0x0001A76C File Offset: 0x0001896C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EF1 RID: 3825
			// (get) Token: 0x06003341 RID: 13121 RVA: 0x000C174C File Offset: 0x000BF94C
			// (set) Token: 0x06003342 RID: 13122 RVA: 0x0001A775 File Offset: 0x00018975
			public unsafe static FlavoredLayout.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredLayout.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredLayout.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredLayout.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF2 RID: 3826
			// (get) Token: 0x06003343 RID: 13123 RVA: 0x000C1774 File Offset: 0x000BF974
			// (set) Token: 0x06003344 RID: 13124 RVA: 0x0001A787 File Offset: 0x00018987
			public unsafe static Func<PileFlavors, int> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredLayout.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PileFlavors, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredLayout.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EF3 RID: 3827
			// (get) Token: 0x06003345 RID: 13125 RVA: 0x000C179C File Offset: 0x000BF99C
			// (set) Token: 0x06003346 RID: 13126 RVA: 0x0001A799 File Offset: 0x00018999
			public unsafe static Func<PileFlavors, FlavoredLayout.Container> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredLayout.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PileFlavors, FlavoredLayout.Container>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredLayout.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F9A RID: 8090
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001F9B RID: 8091
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001F9C RID: 8092
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04001F9D RID: 8093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F9E RID: 8094
			private static readonly IntPtr NativeMethodInfoPtr__get_SortedContainers_b__5_0_Internal_Int32_PileFlavors_0;

			// Token: 0x04001F9F RID: 8095
			private static readonly IntPtr NativeMethodInfoPtr__get_SortedContainers_b__5_1_Internal_Container_PileFlavors_0;
		}
	}
}
