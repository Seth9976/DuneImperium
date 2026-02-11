using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x0200015E RID: 350
	public class WormShippingTrackTroopsRenderer : VersionedView<ReadOnlyVersionedList<EntityComponent>>
	{
		// Token: 0x06000FA9 RID: 4009 RVA: 0x000471F8 File Offset: 0x000453F8
		// Note: this type is marked as 'beforefieldinit'.
		static WormShippingTrackTroopsRenderer()
		{
			Il2CppClassPointerStore<WormShippingTrackTroopsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormShippingTrackTroopsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer>.NativeClassPtr);
			WormShippingTrackTroopsRenderer.NativeFieldInfoPtr_thirdTroop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer>.NativeClassPtr, "thirdTroop");
			WormShippingTrackTroopsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer>.NativeClassPtr, 100665414);
			WormShippingTrackTroopsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer>.NativeClassPtr, 100665415);
			WormShippingTrackTroopsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer>.NativeClassPtr, 100665416);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00047278 File Offset: 0x00045478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708077, XrefRangeEnd = 708094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShippingTrackTroopsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000472B4 File Offset: 0x000454B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708094, XrefRangeEnd = 708114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShippingTrackTroopsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x000472F0 File Offset: 0x000454F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708114, XrefRangeEnd = 708117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShippingTrackTroopsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackTroopsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0000A41A File Offset: 0x0000861A
		public WormShippingTrackTroopsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0004732C File Offset: 0x0004552C
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0000A423 File Offset: 0x00008623
		public unsafe GameObject thirdTroop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrackTroopsRenderer.NativeFieldInfoPtr_thirdTroop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrackTroopsRenderer.NativeFieldInfoPtr_thirdTroop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_thirdTroop;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A2 RID: 930
		[ObfuscatedName("worm.match.dataRenderers.WormShippingTrackTroopsRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600257E RID: 9598 RVA: 0x000895E8 File Offset: 0x000877E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormShippingTrackTroopsRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer.__c>.NativeClassPtr);
				WormShippingTrackTroopsRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer.__c>.NativeClassPtr, "<>9");
				WormShippingTrackTroopsRenderer.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer.__c>.NativeClassPtr, "<>9__2_0");
				WormShippingTrackTroopsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer.__c>.NativeClassPtr, 100665418);
				WormShippingTrackTroopsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__2_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer.__c>.NativeClassPtr, 100665419);
			}

			// Token: 0x0600257F RID: 9599 RVA: 0x00089664 File Offset: 0x00087864
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShippingTrackTroopsRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackTroopsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002580 RID: 9600 RVA: 0x000896A0 File Offset: 0x000878A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708058, XrefRangeEnd = 708077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__2_0(EntityComponent tech)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tech);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrackTroopsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__2_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002581 RID: 9601 RVA: 0x00014E12 File Offset: 0x00013012
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x06002582 RID: 9602 RVA: 0x000896F0 File Offset: 0x000878F0
			// (set) Token: 0x06002583 RID: 9603 RVA: 0x00014E1B File Offset: 0x0001301B
			public unsafe static WormShippingTrackTroopsRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShippingTrackTroopsRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShippingTrackTroopsRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShippingTrackTroopsRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x06002584 RID: 9604 RVA: 0x00089718 File Offset: 0x00087918
			// (set) Token: 0x06002585 RID: 9605 RVA: 0x00014E2D File Offset: 0x0001302D
			public unsafe static Func<EntityComponent, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShippingTrackTroopsRenderer.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShippingTrackTroopsRenderer.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001586 RID: 5510
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001587 RID: 5511
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001588 RID: 5512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001589 RID: 5513
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__2_0_Internal_Boolean_EntityComponent_0;
		}
	}
}
