using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace worm.client.match.render.layout
{
	// Token: 0x020002A4 RID: 676
	public class StackedArchetypeLayout : MonoBehaviour
	{
		// Token: 0x06001B67 RID: 7015 RVA: 0x0006C588 File Offset: 0x0006A788
		// Note: this type is marked as 'beforefieldinit'.
		static StackedArchetypeLayout()
		{
			Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render.layout", "StackedArchetypeLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr);
			StackedArchetypeLayout.NativeFieldInfoPtr_slotPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, "slotPrototype");
			StackedArchetypeLayout.NativeFieldInfoPtr_reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, "reverse");
			StackedArchetypeLayout.NativeFieldInfoPtr_hideSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, "hideSlots");
			StackedArchetypeLayout.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, "slots");
			StackedArchetypeLayout.NativeFieldInfoPtr_views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, "views");
			StackedArchetypeLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, 100667293);
			StackedArchetypeLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, 100667294);
			StackedArchetypeLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, 100667295);
			StackedArchetypeLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, 100667296);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0006C66C File Offset: 0x0006A86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724742, XrefRangeEnd = 724826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> newViews)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newViews);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedArchetypeLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0006C6B0 File Offset: 0x0006A8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724826, XrefRangeEnd = 724891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedArchetypeLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0006C710 File Offset: 0x0006A910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724891, XrefRangeEnd = 724918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedArchetypeLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0006C744 File Offset: 0x0006A944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724918, XrefRangeEnd = 724933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackedArchetypeLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedArchetypeLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0000FD45 File Offset: 0x0000DF45
		public StackedArchetypeLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0006C780 File Offset: 0x0006A980
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0000FD4E File Offset: 0x0000DF4E
		public unsafe Transform slotPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_slotPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_slotPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0006C7B0 File Offset: 0x0006A9B0
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0000FD6D File Offset: 0x0000DF6D
		public unsafe bool reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_reverse)) = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x0006C7D8 File Offset: 0x0006A9D8
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x0000FD88 File Offset: 0x0000DF88
		public unsafe bool hideSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_hideSlots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_hideSlots)) = value;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0006C800 File Offset: 0x0006AA00
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x0000FDA3 File Offset: 0x0000DFA3
		public unsafe List<Transform> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0006C830 File Offset: 0x0006AA30
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0000FDC2 File Offset: 0x0000DFC2
		public unsafe List<UnitView> views
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_views);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.NativeFieldInfoPtr_views), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeFieldInfoPtr_slotPrototype;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeFieldInfoPtr_reverse;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeFieldInfoPtr_hideSlots;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeFieldInfoPtr_views;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200043F RID: 1087
		[ObfuscatedName("worm.client.match.render.layout.StackedArchetypeLayout+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002D37 RID: 11575 RVA: 0x000A11DC File Offset: 0x0009F3DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StackedArchetypeLayout.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackedArchetypeLayout.__c>.NativeClassPtr);
				StackedArchetypeLayout.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedArchetypeLayout.__c>.NativeClassPtr, "<>9");
				StackedArchetypeLayout.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedArchetypeLayout.__c>.NativeClassPtr, "<>9__5_0");
				StackedArchetypeLayout.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedArchetypeLayout.__c>.NativeClassPtr, 100667298);
				StackedArchetypeLayout.__c.NativeMethodInfoPtr__Layout_b__5_0_Internal_ArchetypeID_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedArchetypeLayout.__c>.NativeClassPtr, 100667299);
			}

			// Token: 0x06002D38 RID: 11576 RVA: 0x000A1258 File Offset: 0x0009F458
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackedArchetypeLayout.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedArchetypeLayout.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D39 RID: 11577 RVA: 0x000A1294 File Offset: 0x0009F494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724676, XrefRangeEnd = 724687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _Layout_b__5_0(UnitView view)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedArchetypeLayout.__c.NativeMethodInfoPtr__Layout_b__5_0_Internal_ArchetypeID_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06002D3A RID: 11578 RVA: 0x0001883D File Offset: 0x00016A3D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CFC RID: 3324
			// (get) Token: 0x06002D3B RID: 11579 RVA: 0x000A12E4 File Offset: 0x0009F4E4
			// (set) Token: 0x06002D3C RID: 11580 RVA: 0x00018846 File Offset: 0x00016A46
			public unsafe static StackedArchetypeLayout.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StackedArchetypeLayout.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackedArchetypeLayout.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StackedArchetypeLayout.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CFD RID: 3325
			// (get) Token: 0x06002D3D RID: 11581 RVA: 0x000A130C File Offset: 0x0009F50C
			// (set) Token: 0x06002D3E RID: 11582 RVA: 0x00018858 File Offset: 0x00016A58
			public unsafe static Func<UnitView, ArchetypeID> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StackedArchetypeLayout.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UnitView, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StackedArchetypeLayout.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A4C RID: 6732
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001A4D RID: 6733
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001A4E RID: 6734
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A4F RID: 6735
			private static readonly IntPtr NativeMethodInfoPtr__Layout_b__5_0_Internal_ArchetypeID_UnitView_0;
		}

		// Token: 0x02000440 RID: 1088
		[ObfuscatedName("worm.client.match.render.layout.StackedArchetypeLayout+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D3F RID: 11583 RVA: 0x000A1334 File Offset: 0x0009F534
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<StackedArchetypeLayout.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StackedArchetypeLayout>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackedArchetypeLayout.__c__DisplayClass6_0>.NativeClassPtr);
				StackedArchetypeLayout.__c__DisplayClass6_0.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackedArchetypeLayout.__c__DisplayClass6_0>.NativeClassPtr, "view");
				StackedArchetypeLayout.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedArchetypeLayout.__c__DisplayClass6_0>.NativeClassPtr, 100667300);
				StackedArchetypeLayout.__c__DisplayClass6_0.NativeMethodInfoPtr__GetSlotFor_b__0_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackedArchetypeLayout.__c__DisplayClass6_0>.NativeClassPtr, 100667301);
			}

			// Token: 0x06002D40 RID: 11584 RVA: 0x000A139C File Offset: 0x0009F59C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackedArchetypeLayout.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedArchetypeLayout.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D41 RID: 11585 RVA: 0x000A13D8 File Offset: 0x0009F5D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724687, XrefRangeEnd = 724742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSlotFor_b__0(UnitView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackedArchetypeLayout.__c__DisplayClass6_0.NativeMethodInfoPtr__GetSlotFor_b__0_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D42 RID: 11586 RVA: 0x0001886A File Offset: 0x00016A6A
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CFE RID: 3326
			// (get) Token: 0x06002D43 RID: 11587 RVA: 0x000A1428 File Offset: 0x0009F628
			// (set) Token: 0x06002D44 RID: 11588 RVA: 0x00018873 File Offset: 0x00016A73
			public unsafe UnitView view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.__c__DisplayClass6_0.NativeFieldInfoPtr_view);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackedArchetypeLayout.__c__DisplayClass6_0.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A50 RID: 6736
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x04001A51 RID: 6737
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A52 RID: 6738
			private static readonly IntPtr NativeMethodInfoPtr__GetSlotFor_b__0_Internal_Boolean_UnitView_0;
		}
	}
}
