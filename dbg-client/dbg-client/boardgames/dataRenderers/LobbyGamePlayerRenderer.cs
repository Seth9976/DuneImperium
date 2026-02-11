using System;
using boardgames.data;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.dataRenderers
{
	// Token: 0x02000152 RID: 338
	public class LobbyGamePlayerRenderer : VersionedSubscriber<PendingGameData>
	{
		// Token: 0x06000F39 RID: 3897 RVA: 0x0004E0D4 File Offset: 0x0004C2D4
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGamePlayerRenderer()
		{
			Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "LobbyGamePlayerRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr);
			LobbyGamePlayerRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr, "atlasName");
			LobbyGamePlayerRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr, "spriteNameFormat");
			LobbyGamePlayerRenderer.NativeFieldInfoPtr_playerSlotPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr, "playerSlotPrototype");
			LobbyGamePlayerRenderer.NativeFieldInfoPtr_slotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr, "slotContainer");
			LobbyGamePlayerRenderer.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr, "slots");
			LobbyGamePlayerRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr, 100665496);
			LobbyGamePlayerRenderer.NativeMethodInfoPtr_configurePlayerSlot_Protected_Virtual_New_Void_DataComposition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr, 100665497);
			LobbyGamePlayerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr, 100665498);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0004E1A4 File Offset: 0x0004C3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513141, XrefRangeEnd = 513208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyGamePlayerRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0004E1E0 File Offset: 0x0004C3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513208, XrefRangeEnd = 513256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void configurePlayerSlot(DataComposition playerData, int slotIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyGamePlayerRenderer.NativeMethodInfoPtr_configurePlayerSlot_Protected_Virtual_New_Void_DataComposition_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0004E23C File Offset: 0x0004C43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513256, XrefRangeEnd = 513271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyGamePlayerRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGamePlayerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00009502 File Offset: 0x00007702
		public LobbyGamePlayerRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0004E278 File Offset: 0x0004C478
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x0000950B File Offset: 0x0000770B
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0004E2A0 File Offset: 0x0004C4A0
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x0000952A File Offset: 0x0000772A
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0004E2C8 File Offset: 0x0004C4C8
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00009549 File Offset: 0x00007749
		public unsafe Image playerSlotPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_playerSlotPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_playerSlotPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0004E2F8 File Offset: 0x0004C4F8
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x00009568 File Offset: 0x00007768
		public unsafe Transform slotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_slotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_slotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x0004E328 File Offset: 0x0004C528
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x00009587 File Offset: 0x00007787
		public unsafe List<Image> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerRenderer.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_playerSlotPrototype;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_slotContainer;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_configurePlayerSlot_Protected_Virtual_New_Void_DataComposition_Int32_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200036D RID: 877
		[ObfuscatedName("boardgames.dataRenderers.LobbyGamePlayerRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600294A RID: 10570 RVA: 0x000A40D0 File Offset: 0x000A22D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyGamePlayerRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr);
				LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr, "<>9");
				LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr, "<>9__5_0");
				LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr, "<>9__5_1");
				LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr, "<>9__5_2");
				LobbyGamePlayerRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr, 100665500);
				LobbyGamePlayerRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_0_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr, 100665501);
				LobbyGamePlayerRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_1_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr, 100665502);
				LobbyGamePlayerRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_2_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr, 100665503);
			}

			// Token: 0x0600294B RID: 10571 RVA: 0x000A419C File Offset: 0x000A239C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGamePlayerRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGamePlayerRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600294C RID: 10572 RVA: 0x000A41D8 File Offset: 0x000A23D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513132, XrefRangeEnd = 513135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__5_0(DataComposition p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGamePlayerRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_0_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600294D RID: 10573 RVA: 0x000A4228 File Offset: 0x000A2428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513135, XrefRangeEnd = 513138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__5_1(DataComposition p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGamePlayerRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_1_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600294E RID: 10574 RVA: 0x000A4278 File Offset: 0x000A2478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513138, XrefRangeEnd = 513141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__5_2(DataComposition p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGamePlayerRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_2_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600294F RID: 10575 RVA: 0x0001554A File Offset: 0x0001374A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B9B RID: 2971
			// (get) Token: 0x06002950 RID: 10576 RVA: 0x000A42C8 File Offset: 0x000A24C8
			// (set) Token: 0x06002951 RID: 10577 RVA: 0x00015553 File Offset: 0x00013753
			public unsafe static LobbyGamePlayerRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyGamePlayerRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B9C RID: 2972
			// (get) Token: 0x06002952 RID: 10578 RVA: 0x000A42F0 File Offset: 0x000A24F0
			// (set) Token: 0x06002953 RID: 10579 RVA: 0x00015565 File Offset: 0x00013765
			public unsafe static Func<DataComposition, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataComposition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B9D RID: 2973
			// (get) Token: 0x06002954 RID: 10580 RVA: 0x000A4318 File Offset: 0x000A2518
			// (set) Token: 0x06002955 RID: 10581 RVA: 0x00015577 File Offset: 0x00013777
			public unsafe static Func<DataComposition, bool> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataComposition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B9E RID: 2974
			// (get) Token: 0x06002956 RID: 10582 RVA: 0x000A4340 File Offset: 0x000A2540
			// (set) Token: 0x06002957 RID: 10583 RVA: 0x00015589 File Offset: 0x00013789
			public unsafe static Func<DataComposition, bool> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataComposition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LobbyGamePlayerRenderer.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019CD RID: 6605
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040019CE RID: 6606
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040019CF RID: 6607
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x040019D0 RID: 6608
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x040019D1 RID: 6609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019D2 RID: 6610
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__5_0_Internal_Boolean_DataComposition_0;

			// Token: 0x040019D3 RID: 6611
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__5_1_Internal_Boolean_DataComposition_0;

			// Token: 0x040019D4 RID: 6612
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__5_2_Internal_Boolean_DataComposition_0;
		}
	}
}
