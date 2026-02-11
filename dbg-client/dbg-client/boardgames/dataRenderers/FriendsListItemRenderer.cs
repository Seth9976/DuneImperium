using System;
using boardgames.data;
using dwd.core.data.composition;
using dwd.core.platform.websocket.incoming;
using dwd.core.prefabs.prefabProvider;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.dataRenderers
{
	// Token: 0x0200014D RID: 333
	public class FriendsListItemRenderer : VersionedSubscriber<FriendsListData>
	{
		// Token: 0x06000F16 RID: 3862 RVA: 0x0004DAA0 File Offset: 0x0004BCA0
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsListItemRenderer()
		{
			Il2CppClassPointerStore<FriendsListItemRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "FriendsListItemRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListItemRenderer>.NativeClassPtr);
			FriendsListItemRenderer.NativeFieldInfoPtr_providerInstantiator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListItemRenderer>.NativeClassPtr, "providerInstantiator");
			FriendsListItemRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListItemRenderer>.NativeClassPtr, 100665482);
			FriendsListItemRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListItemRenderer>.NativeClassPtr, 100665483);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0004DB0C File Offset: 0x0004BD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513033, XrefRangeEnd = 513059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendsListItemRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0004DB48 File Offset: 0x0004BD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513059, XrefRangeEnd = 513062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsListItemRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListItemRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListItemRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000093FC File Offset: 0x000075FC
		public FriendsListItemRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x0004DB84 File Offset: 0x0004BD84
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x00009405 File Offset: 0x00007605
		public unsafe ProviderInstantiator providerInstantiator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListItemRenderer.NativeFieldInfoPtr_providerInstantiator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProviderInstantiator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListItemRenderer.NativeFieldInfoPtr_providerInstantiator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeFieldInfoPtr_providerInstantiator;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200036B RID: 875
		[ObfuscatedName("boardgames.dataRenderers.FriendsListItemRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600293B RID: 10555 RVA: 0x000A3EC4 File Offset: 0x000A20C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FriendsListItemRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendsListItemRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListItemRenderer.__c>.NativeClassPtr);
				FriendsListItemRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListItemRenderer.__c>.NativeClassPtr, "<>9");
				FriendsListItemRenderer.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListItemRenderer.__c>.NativeClassPtr, "<>9__1_0");
				FriendsListItemRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListItemRenderer.__c>.NativeClassPtr, 100665485);
				FriendsListItemRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__1_0_Internal_DataComposition_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListItemRenderer.__c>.NativeClassPtr, 100665486);
			}

			// Token: 0x0600293C RID: 10556 RVA: 0x000A3F40 File Offset: 0x000A2140
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListItemRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListItemRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600293D RID: 10557 RVA: 0x000A3F7C File Offset: 0x000A217C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512986, XrefRangeEnd = 513033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataComposition _dirtyUpdate_b__1_0(RosterEntry friend)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListItemRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__1_0_Internal_DataComposition_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
				}
			}

			// Token: 0x0600293E RID: 10558 RVA: 0x000154C4 File Offset: 0x000136C4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B97 RID: 2967
			// (get) Token: 0x0600293F RID: 10559 RVA: 0x000A3FCC File Offset: 0x000A21CC
			// (set) Token: 0x06002940 RID: 10560 RVA: 0x000154CD File Offset: 0x000136CD
			public unsafe static FriendsListItemRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsListItemRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListItemRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsListItemRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B98 RID: 2968
			// (get) Token: 0x06002941 RID: 10561 RVA: 0x000A3FF4 File Offset: 0x000A21F4
			// (set) Token: 0x06002942 RID: 10562 RVA: 0x000154DF File Offset: 0x000136DF
			public unsafe static Func<RosterEntry, DataComposition> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsListItemRenderer.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, DataComposition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsListItemRenderer.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019C7 RID: 6599
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040019C8 RID: 6600
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040019C9 RID: 6601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019CA RID: 6602
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__1_0_Internal_DataComposition_RosterEntry_0;
		}
	}
}
