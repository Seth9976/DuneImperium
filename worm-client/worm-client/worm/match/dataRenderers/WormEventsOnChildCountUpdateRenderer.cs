using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine.Events;

namespace worm.match.dataRenderers
{
	// Token: 0x02000120 RID: 288
	public class WormEventsOnChildCountUpdateRenderer : Observer
	{
		// Token: 0x06000D2E RID: 3374 RVA: 0x00040144 File Offset: 0x0003E344
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsOnChildCountUpdateRenderer()
		{
			Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormEventsOnChildCountUpdateRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer>.NativeClassPtr);
			WormEventsOnChildCountUpdateRenderer.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer>.NativeClassPtr, "onUpdate");
			WormEventsOnChildCountUpdateRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer>.NativeClassPtr, 100665100);
			WormEventsOnChildCountUpdateRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer>.NativeClassPtr, 100665101);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x000401B0 File Offset: 0x0003E3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705370, XrefRangeEnd = 705426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsOnChildCountUpdateRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x000401EC File Offset: 0x0003E3EC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsOnChildCountUpdateRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsOnChildCountUpdateRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00008F88 File Offset: 0x00007188
		public WormEventsOnChildCountUpdateRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00040228 File Offset: 0x0003E428
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00008F91 File Offset: 0x00007191
		public unsafe UnityEvent<Il2CppStructArray<int>> onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsOnChildCountUpdateRenderer.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsOnChildCountUpdateRenderer.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000380 RID: 896
		[ObfuscatedName("worm.match.dataRenderers.WormEventsOnChildCountUpdateRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600240E RID: 9230 RVA: 0x00085494 File Offset: 0x00083694
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer.__c>.NativeClassPtr);
				WormEventsOnChildCountUpdateRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer.__c>.NativeClassPtr, "<>9");
				WormEventsOnChildCountUpdateRenderer.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer.__c>.NativeClassPtr, "<>9__1_0");
				WormEventsOnChildCountUpdateRenderer.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer.__c>.NativeClassPtr, "<>9__1_1");
				WormEventsOnChildCountUpdateRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer.__c>.NativeClassPtr, 100665103);
				WormEventsOnChildCountUpdateRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__1_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer.__c>.NativeClassPtr, 100665104);
				WormEventsOnChildCountUpdateRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__1_1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer.__c>.NativeClassPtr, 100665105);
			}

			// Token: 0x0600240F RID: 9231 RVA: 0x00085538 File Offset: 0x00083738
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsOnChildCountUpdateRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsOnChildCountUpdateRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002410 RID: 9232 RVA: 0x00085574 File Offset: 0x00083774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705356, XrefRangeEnd = 705363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__1_0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsOnChildCountUpdateRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__1_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002411 RID: 9233 RVA: 0x000855C4 File Offset: 0x000837C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705363, XrefRangeEnd = 705370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirtyUpdate_b__1_1(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsOnChildCountUpdateRenderer.__c.NativeMethodInfoPtr__DirtyUpdate_b__1_1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002412 RID: 9234 RVA: 0x000141F0 File Offset: 0x000123F0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009F9 RID: 2553
			// (get) Token: 0x06002413 RID: 9235 RVA: 0x00085614 File Offset: 0x00083814
			// (set) Token: 0x06002414 RID: 9236 RVA: 0x000141F9 File Offset: 0x000123F9
			public unsafe static WormEventsOnChildCountUpdateRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEventsOnChildCountUpdateRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsOnChildCountUpdateRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEventsOnChildCountUpdateRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FA RID: 2554
			// (get) Token: 0x06002415 RID: 9237 RVA: 0x0008563C File Offset: 0x0008383C
			// (set) Token: 0x06002416 RID: 9238 RVA: 0x0001420B File Offset: 0x0001240B
			public unsafe static Func<EntityComponent, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEventsOnChildCountUpdateRenderer.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEventsOnChildCountUpdateRenderer.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x06002417 RID: 9239 RVA: 0x00085664 File Offset: 0x00083864
			// (set) Token: 0x06002418 RID: 9240 RVA: 0x0001421D File Offset: 0x0001241D
			public unsafe static Func<EntityComponent, bool> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEventsOnChildCountUpdateRenderer.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEventsOnChildCountUpdateRenderer.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014AD RID: 5293
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014AE RID: 5294
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040014AF RID: 5295
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x040014B0 RID: 5296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014B1 RID: 5297
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__1_0_Internal_Boolean_EntityComponent_0;

			// Token: 0x040014B2 RID: 5298
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__1_1_Internal_Boolean_EntityComponent_0;
		}
	}
}
