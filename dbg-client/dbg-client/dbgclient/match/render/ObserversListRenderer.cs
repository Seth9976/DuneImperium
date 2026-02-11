using System;
using boardgames.match.data;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.prefabs.prefabProvider;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dbgclient.match.render
{
	// Token: 0x020000A7 RID: 167
	public class ObserversListRenderer : VersionedSubscriber<ObserversListData>
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x00032600 File Offset: 0x00030800
		// Note: this type is marked as 'beforefieldinit'.
		static ObserversListRenderer()
		{
			Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.match.render", "ObserversListRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr);
			ObserversListRenderer.NativeFieldInfoPtr_providerInstantiator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr, "providerInstantiator");
			ObserversListRenderer.NativeFieldInfoPtr_observerDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr, "observerDatas");
			ObserversListRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr, 100664336);
			ObserversListRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr, 100664337);
			ObserversListRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr, 100664338);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00032694 File Offset: 0x00030894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503583, XrefRangeEnd = 503588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserversListRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000326D0 File Offset: 0x000308D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503588, XrefRangeEnd = 503667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserversListRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0003270C File Offset: 0x0003090C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503667, XrefRangeEnd = 503677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserversListRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversListRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00004F5D File Offset: 0x0000315D
		public ObserversListRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00032748 File Offset: 0x00030948
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00004F66 File Offset: 0x00003166
		public unsafe ProviderInstantiator providerInstantiator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListRenderer.NativeFieldInfoPtr_providerInstantiator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProviderInstantiator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListRenderer.NativeFieldInfoPtr_providerInstantiator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00032778 File Offset: 0x00030978
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00004F85 File Offset: 0x00003185
		public unsafe VersionedList<DataComposition> observerDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListRenderer.NativeFieldInfoPtr_observerDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListRenderer.NativeFieldInfoPtr_observerDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_providerInstantiator;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_observerDatas;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000317 RID: 791
		[ObfuscatedName("dbgclient.match.render.ObserversListRenderer+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600256A RID: 9578 RVA: 0x00098644 File Offset: 0x00096844
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_0>.NativeClassPtr);
				ObserversListRenderer.__c__DisplayClass3_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_0>.NativeClassPtr, "accountID");
				ObserversListRenderer.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_0>.NativeClassPtr, 100664339);
				ObserversListRenderer.__c__DisplayClass3_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_0>.NativeClassPtr, 100664340);
			}

			// Token: 0x0600256B RID: 9579 RVA: 0x000986AC File Offset: 0x000968AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversListRenderer.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600256C RID: 9580 RVA: 0x000986E8 File Offset: 0x000968E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503570, XrefRangeEnd = 503575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__0(AccountIDUsernameMetadata o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversListRenderer.__c__DisplayClass3_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600256D RID: 9581 RVA: 0x000136CF File Offset: 0x000118CF
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A4D RID: 2637
			// (get) Token: 0x0600256E RID: 9582 RVA: 0x00098738 File Offset: 0x00096938
			// (set) Token: 0x0600256F RID: 9583 RVA: 0x000136D8 File Offset: 0x000118D8
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListRenderer.__c__DisplayClass3_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListRenderer.__c__DisplayClass3_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400177D RID: 6013
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x0400177E RID: 6014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400177F RID: 6015
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000318 RID: 792
		[ObfuscatedName("dbgclient.match.render.ObserversListRenderer+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x06002570 RID: 9584 RVA: 0x00098768 File Offset: 0x00096968
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObserversListRenderer>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_1>.NativeClassPtr);
				ObserversListRenderer.__c__DisplayClass3_1.NativeFieldInfoPtr_accountIDUsernameMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_1>.NativeClassPtr, "accountIDUsernameMetadata");
				ObserversListRenderer.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_1>.NativeClassPtr, 100664341);
				ObserversListRenderer.__c__DisplayClass3_1.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_1>.NativeClassPtr, 100664342);
			}

			// Token: 0x06002571 RID: 9585 RVA: 0x000987D0 File Offset: 0x000969D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserversListRenderer.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversListRenderer.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002572 RID: 9586 RVA: 0x0009880C File Offset: 0x00096A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503575, XrefRangeEnd = 503583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__1(DataComposition od)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(od);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserversListRenderer.__c__DisplayClass3_1.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002573 RID: 9587 RVA: 0x000136F7 File Offset: 0x000118F7
			public __c__DisplayClass3_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A4E RID: 2638
			// (get) Token: 0x06002574 RID: 9588 RVA: 0x0009885C File Offset: 0x00096A5C
			// (set) Token: 0x06002575 RID: 9589 RVA: 0x00013700 File Offset: 0x00011900
			public unsafe AccountIDUsernameMetadata accountIDUsernameMetadata
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListRenderer.__c__DisplayClass3_1.NativeFieldInfoPtr_accountIDUsernameMetadata);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserversListRenderer.__c__DisplayClass3_1.NativeFieldInfoPtr_accountIDUsernameMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001780 RID: 6016
			private static readonly IntPtr NativeFieldInfoPtr_accountIDUsernameMetadata;

			// Token: 0x04001781 RID: 6017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001782 RID: 6018
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_DataComposition_0;
		}
	}
}
