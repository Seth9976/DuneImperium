using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;
using worm.canis.data.enums;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000115 RID: 277
	public class WormEntityChildrenColorDisplaySubscriber : VersionedSubscriber<WormColorData>
	{
		// Token: 0x06000CC5 RID: 3269 RVA: 0x0003EE0C File Offset: 0x0003D00C
		// Note: this type is marked as 'beforefieldinit'.
		static WormEntityChildrenColorDisplaySubscriber()
		{
			Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEntityChildrenColorDisplaySubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr);
			WormEntityChildrenColorDisplaySubscriber.NativeFieldInfoPtr_colorDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr, "colorDisplay");
			WormEntityChildrenColorDisplaySubscriber.NativeFieldInfoPtr_parentEntityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr, "parentEntityView");
			WormEntityChildrenColorDisplaySubscriber.NativeFieldInfoPtr_childEntityNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr, "childEntityNames");
			WormEntityChildrenColorDisplaySubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr, 100665048);
			WormEntityChildrenColorDisplaySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr, 100665049);
			WormEntityChildrenColorDisplaySubscriber.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr, 100665050);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0003EEB4 File Offset: 0x0003D0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704887, XrefRangeEnd = 704928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityChildrenColorDisplaySubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0003EEF0 File Offset: 0x0003D0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704928, XrefRangeEnd = 704935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEntityChildrenColorDisplaySubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityChildrenColorDisplaySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0003EF2C File Offset: 0x0003D12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704935, XrefRangeEnd = 704942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__3_0(EntityComponent c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityChildrenColorDisplaySubscriber.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00008BF9 File Offset: 0x00006DF9
		public WormEntityChildrenColorDisplaySubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0003EF7C File Offset: 0x0003D17C
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00008C02 File Offset: 0x00006E02
		public unsafe GameObject colorDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityChildrenColorDisplaySubscriber.NativeFieldInfoPtr_colorDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityChildrenColorDisplaySubscriber.NativeFieldInfoPtr_colorDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0003EFAC File Offset: 0x0003D1AC
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00008C21 File Offset: 0x00006E21
		public unsafe EntityView parentEntityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityChildrenColorDisplaySubscriber.NativeFieldInfoPtr_parentEntityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityChildrenColorDisplaySubscriber.NativeFieldInfoPtr_parentEntityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0003EFDC File Offset: 0x0003D1DC
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00008C40 File Offset: 0x00006E40
		public unsafe Il2CppStringArray childEntityNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityChildrenColorDisplaySubscriber.NativeFieldInfoPtr_childEntityNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityChildrenColorDisplaySubscriber.NativeFieldInfoPtr_childEntityNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplay;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeFieldInfoPtr_parentEntityView;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeFieldInfoPtr_childEntityNames;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__3_0_Private_Boolean_EntityComponent_0;

		// Token: 0x02000377 RID: 887
		[ObfuscatedName("worm.match.dataRenderers.WormEntityChildrenColorDisplaySubscriber+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060023BA RID: 9146 RVA: 0x00084778 File Offset: 0x00082978
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber.__c>.NativeClassPtr);
				WormEntityChildrenColorDisplaySubscriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber.__c>.NativeClassPtr, "<>9");
				WormEntityChildrenColorDisplaySubscriber.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber.__c>.NativeClassPtr, "<>9__3_1");
				WormEntityChildrenColorDisplaySubscriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber.__c>.NativeClassPtr, 100665052);
				WormEntityChildrenColorDisplaySubscriber.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_1_Internal_Nullable_1_PieceColor_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber.__c>.NativeClassPtr, 100665053);
			}

			// Token: 0x060023BB RID: 9147 RVA: 0x000847F4 File Offset: 0x000829F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntityChildrenColorDisplaySubscriber.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityChildrenColorDisplaySubscriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023BC RID: 9148 RVA: 0x00084830 File Offset: 0x00082A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704876, XrefRangeEnd = 704887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<PieceColor> _dirtyUpdate_b__3_1(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityChildrenColorDisplaySubscriber.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_1_Internal_Nullable_1_PieceColor_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<PieceColor>(intPtr);
				}
			}

			// Token: 0x060023BD RID: 9149 RVA: 0x00013EE4 File Offset: 0x000120E4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009DE RID: 2526
			// (get) Token: 0x060023BE RID: 9150 RVA: 0x00084878 File Offset: 0x00082A78
			// (set) Token: 0x060023BF RID: 9151 RVA: 0x00013EED File Offset: 0x000120ED
			public unsafe static WormEntityChildrenColorDisplaySubscriber.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEntityChildrenColorDisplaySubscriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntityChildrenColorDisplaySubscriber.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEntityChildrenColorDisplaySubscriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009DF RID: 2527
			// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000848A0 File Offset: 0x00082AA0
			// (set) Token: 0x060023C1 RID: 9153 RVA: 0x00013EFF File Offset: 0x000120FF
			public unsafe static Func<EntityComponent, Nullable<PieceColor>> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEntityChildrenColorDisplaySubscriber.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, Nullable<PieceColor>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEntityChildrenColorDisplaySubscriber.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001484 RID: 5252
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001485 RID: 5253
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04001486 RID: 5254
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001487 RID: 5255
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__3_1_Internal_Nullable_1_PieceColor_EntityComponent_0;
		}
	}
}
