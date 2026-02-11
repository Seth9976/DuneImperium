using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using lotus;
using UnityEngine;

namespace worm.client.match.render.layout
{
	// Token: 0x020002A1 RID: 673
	public class DistinctArchetypeLayout : MonoBehaviour
	{
		// Token: 0x06001B53 RID: 6995 RVA: 0x0006C178 File Offset: 0x0006A378
		// Note: this type is marked as 'beforefieldinit'.
		static DistinctArchetypeLayout()
		{
			Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render.layout", "DistinctArchetypeLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr);
			DistinctArchetypeLayout.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr, "slots");
			DistinctArchetypeLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr, 100667277);
			DistinctArchetypeLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr, 100667278);
			DistinctArchetypeLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr, 100667279);
			DistinctArchetypeLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr, 100667280);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0006C20C File Offset: 0x0006A40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724448, XrefRangeEnd = 724562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistinctArchetypeLayout.NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0006C250 File Offset: 0x0006A450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724562, XrefRangeEnd = 724583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistinctArchetypeLayout.NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0006C2B0 File Offset: 0x0006A4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724583, XrefRangeEnd = 724600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistinctArchetypeLayout.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0006C2E4 File Offset: 0x0006A4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724600, XrefRangeEnd = 724608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DistinctArchetypeLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistinctArchetypeLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0000FCCD File Offset: 0x0000DECD
		public DistinctArchetypeLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x0006C320 File Offset: 0x0006A520
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0000FCD6 File Offset: 0x0000DED6
		public unsafe Il2CppReferenceArray<DistinctArchetypeLayout.ArchetypeSlot> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctArchetypeLayout.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DistinctArchetypeLayout.ArchetypeSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctArchetypeLayout.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Virtual_Final_New_Void_List_1_UnitView_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Virtual_Final_New_Transform_UnitView_Int32_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200043C RID: 1084
		[Serializable]
		public sealed class ArchetypeSlot : ValueType
		{
			// Token: 0x06002D18 RID: 11544 RVA: 0x000A0CE4 File Offset: 0x0009EEE4
			// Note: this type is marked as 'beforefieldinit'.
			static ArchetypeSlot()
			{
				Il2CppClassPointerStore<DistinctArchetypeLayout.ArchetypeSlot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr, "ArchetypeSlot");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistinctArchetypeLayout.ArchetypeSlot>.NativeClassPtr);
				DistinctArchetypeLayout.ArchetypeSlot.NativeFieldInfoPtr_archetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistinctArchetypeLayout.ArchetypeSlot>.NativeClassPtr, "archetype");
				DistinctArchetypeLayout.ArchetypeSlot.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistinctArchetypeLayout.ArchetypeSlot>.NativeClassPtr, "slot");
				DistinctArchetypeLayout.ArchetypeSlot.NativeFieldInfoPtr_emptyPlaceholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistinctArchetypeLayout.ArchetypeSlot>.NativeClassPtr, "emptyPlaceholder");
			}

			// Token: 0x06002D19 RID: 11545 RVA: 0x00018747 File Offset: 0x00016947
			public ArchetypeSlot(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D1A RID: 11546 RVA: 0x00018750 File Offset: 0x00016950
			public ArchetypeSlot()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistinctArchetypeLayout.ArchetypeSlot>.NativeClassPtr))
			{
			}

			// Token: 0x17000CF3 RID: 3315
			// (get) Token: 0x06002D1B RID: 11547 RVA: 0x000A0D4C File Offset: 0x0009EF4C
			// (set) Token: 0x06002D1C RID: 11548 RVA: 0x00018762 File Offset: 0x00016962
			public unsafe ArchetypeID archetype
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctArchetypeLayout.ArchetypeSlot.NativeFieldInfoPtr_archetype);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctArchetypeLayout.ArchetypeSlot.NativeFieldInfoPtr_archetype), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CF4 RID: 3316
			// (get) Token: 0x06002D1D RID: 11549 RVA: 0x000A0D7C File Offset: 0x0009EF7C
			// (set) Token: 0x06002D1E RID: 11550 RVA: 0x00018781 File Offset: 0x00016981
			public unsafe Transform slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctArchetypeLayout.ArchetypeSlot.NativeFieldInfoPtr_slot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctArchetypeLayout.ArchetypeSlot.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CF5 RID: 3317
			// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000A0DAC File Offset: 0x0009EFAC
			// (set) Token: 0x06002D20 RID: 11552 RVA: 0x000187A0 File Offset: 0x000169A0
			public unsafe GameObject emptyPlaceholder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctArchetypeLayout.ArchetypeSlot.NativeFieldInfoPtr_emptyPlaceholder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistinctArchetypeLayout.ArchetypeSlot.NativeFieldInfoPtr_emptyPlaceholder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A3D RID: 6717
			private static readonly IntPtr NativeFieldInfoPtr_archetype;

			// Token: 0x04001A3E RID: 6718
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04001A3F RID: 6719
			private static readonly IntPtr NativeFieldInfoPtr_emptyPlaceholder;
		}

		// Token: 0x0200043D RID: 1085
		[ObfuscatedName("worm.client.match.render.layout.DistinctArchetypeLayout+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002D21 RID: 11553 RVA: 0x000A0DDC File Offset: 0x0009EFDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DistinctArchetypeLayout>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr);
				DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr, "<>9");
				DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr, "<>9__2_0");
				DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr, "<>9__2_1");
				DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr, "<>9__2_2");
				DistinctArchetypeLayout.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr, 100667282);
				DistinctArchetypeLayout.__c.NativeMethodInfoPtr__Layout_b__2_0_Internal_ArchetypeID_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr, 100667283);
				DistinctArchetypeLayout.__c.NativeMethodInfoPtr__Layout_b__2_1_Internal_ArchetypeID_IGrouping_2_ArchetypeID_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr, 100667284);
				DistinctArchetypeLayout.__c.NativeMethodInfoPtr__Layout_b__2_2_Internal_List_1_UnitView_IGrouping_2_ArchetypeID_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr, 100667285);
			}

			// Token: 0x06002D22 RID: 11554 RVA: 0x000A0EA8 File Offset: 0x0009F0A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistinctArchetypeLayout.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistinctArchetypeLayout.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D23 RID: 11555 RVA: 0x000A0EE4 File Offset: 0x0009F0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724427, XrefRangeEnd = 724441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _Layout_b__2_0(UnitView view)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistinctArchetypeLayout.__c.NativeMethodInfoPtr__Layout_b__2_0_Internal_ArchetypeID_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06002D24 RID: 11556 RVA: 0x000A0F34 File Offset: 0x0009F134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724441, XrefRangeEnd = 724445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _Layout_b__2_1(IGrouping<ArchetypeID, UnitView> g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistinctArchetypeLayout.__c.NativeMethodInfoPtr__Layout_b__2_1_Internal_ArchetypeID_IGrouping_2_ArchetypeID_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06002D25 RID: 11557 RVA: 0x000A0F84 File Offset: 0x0009F184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724445, XrefRangeEnd = 724448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<UnitView> _Layout_b__2_2(IGrouping<ArchetypeID, UnitView> g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistinctArchetypeLayout.__c.NativeMethodInfoPtr__Layout_b__2_2_Internal_List_1_UnitView_IGrouping_2_ArchetypeID_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr3) : null;
				}
			}

			// Token: 0x06002D26 RID: 11558 RVA: 0x000187BF File Offset: 0x000169BF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CF6 RID: 3318
			// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000A0FD4 File Offset: 0x0009F1D4
			// (set) Token: 0x06002D28 RID: 11560 RVA: 0x000187C8 File Offset: 0x000169C8
			public unsafe static DistinctArchetypeLayout.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DistinctArchetypeLayout.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CF7 RID: 3319
			// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000A0FFC File Offset: 0x0009F1FC
			// (set) Token: 0x06002D2A RID: 11562 RVA: 0x000187DA File Offset: 0x000169DA
			public unsafe static Func<UnitView, ArchetypeID> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UnitView, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CF8 RID: 3320
			// (get) Token: 0x06002D2B RID: 11563 RVA: 0x000A1024 File Offset: 0x0009F224
			// (set) Token: 0x06002D2C RID: 11564 RVA: 0x000187EC File Offset: 0x000169EC
			public unsafe static Func<IGrouping<ArchetypeID, UnitView>, ArchetypeID> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<ArchetypeID, UnitView>, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CF9 RID: 3321
			// (get) Token: 0x06002D2D RID: 11565 RVA: 0x000A104C File Offset: 0x0009F24C
			// (set) Token: 0x06002D2E RID: 11566 RVA: 0x000187FE File Offset: 0x000169FE
			public unsafe static Func<IGrouping<ArchetypeID, UnitView>, List<UnitView>> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<ArchetypeID, UnitView>, List<UnitView>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistinctArchetypeLayout.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A40 RID: 6720
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001A41 RID: 6721
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001A42 RID: 6722
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04001A43 RID: 6723
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x04001A44 RID: 6724
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A45 RID: 6725
			private static readonly IntPtr NativeMethodInfoPtr__Layout_b__2_0_Internal_ArchetypeID_UnitView_0;

			// Token: 0x04001A46 RID: 6726
			private static readonly IntPtr NativeMethodInfoPtr__Layout_b__2_1_Internal_ArchetypeID_IGrouping_2_ArchetypeID_UnitView_0;

			// Token: 0x04001A47 RID: 6727
			private static readonly IntPtr NativeMethodInfoPtr__Layout_b__2_2_Internal_List_1_UnitView_IGrouping_2_ArchetypeID_UnitView_0;
		}
	}
}
