using System;
using Canis.utils.ids;
using dwd.core.prefabs.prefabProvider;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.canis.dbg_client.dataRenderers
{
	// Token: 0x0200007A RID: 122
	public class FriendsListChatReopener : MonoBehaviour
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x0002BE50 File Offset: 0x0002A050
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsListChatReopener()
		{
			Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.dataRenderers", "FriendsListChatReopener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr);
			FriendsListChatReopener.NativeFieldInfoPtr_friendEntryInstantiators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr, "friendEntryInstantiators");
			FriendsListChatReopener.NativeFieldInfoPtr_registeredChatViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr, "registeredChatViews");
			FriendsListChatReopener.NativeFieldInfoPtr_openChatPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr, "openChatPanel");
			FriendsListChatReopener.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr, 100664000);
			FriendsListChatReopener.NativeMethodInfoPtr_OnInstantiateComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr, 100664001);
			FriendsListChatReopener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr, 100664002);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0002BEF8 File Offset: 0x0002A0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500924, XrefRangeEnd = 500932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListChatReopener.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0002BF2C File Offset: 0x0002A12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500932, XrefRangeEnd = 501016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInstantiateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListChatReopener.NativeMethodInfoPtr_OnInstantiateComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0002BF60 File Offset: 0x0002A160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501016, XrefRangeEnd = 501028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsListChatReopener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListChatReopener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000040F7 File Offset: 0x000022F7
		public FriendsListChatReopener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0002BF9C File Offset: 0x0002A19C
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00004100 File Offset: 0x00002300
		public unsafe Il2CppReferenceArray<ProviderInstantiator> friendEntryInstantiators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.NativeFieldInfoPtr_friendEntryInstantiators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProviderInstantiator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.NativeFieldInfoPtr_friendEntryInstantiators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0002BFCC File Offset: 0x0002A1CC
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0000411F File Offset: 0x0000231F
		public unsafe List<FriendChatView> registeredChatViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.NativeFieldInfoPtr_registeredChatViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FriendChatView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.NativeFieldInfoPtr_registeredChatViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0002BFFC File Offset: 0x0002A1FC
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0000413E File Offset: 0x0000233E
		public unsafe AccountID openChatPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.NativeFieldInfoPtr_openChatPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.NativeFieldInfoPtr_openChatPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr_friendEntryInstantiators;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr_registeredChatViews;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr_openChatPanel;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_OnInstantiateComplete_Private_Void_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F9 RID: 761
		[ObfuscatedName("dwd.canis.dbg_client.dataRenderers.FriendsListChatReopener+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060023ED RID: 9197 RVA: 0x00093F6C File Offset: 0x0009216C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FriendsListChatReopener.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListChatReopener.__c>.NativeClassPtr);
				FriendsListChatReopener.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListChatReopener.__c>.NativeClassPtr, "<>9");
				FriendsListChatReopener.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListChatReopener.__c>.NativeClassPtr, "<>9__4_0");
				FriendsListChatReopener.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListChatReopener.__c>.NativeClassPtr, "<>9__4_1");
				FriendsListChatReopener.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListChatReopener.__c>.NativeClassPtr, 100664004);
				FriendsListChatReopener.__c.NativeMethodInfoPtr__OnInstantiateComplete_b__4_0_Internal_Boolean_FriendChatView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListChatReopener.__c>.NativeClassPtr, 100664005);
				FriendsListChatReopener.__c.NativeMethodInfoPtr__OnInstantiateComplete_b__4_1_Internal_IEnumerable_1_FriendChatResponder_ProviderInstantiator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListChatReopener.__c>.NativeClassPtr, 100664006);
			}

			// Token: 0x060023EE RID: 9198 RVA: 0x00094010 File Offset: 0x00092210
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListChatReopener.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListChatReopener.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023EF RID: 9199 RVA: 0x0009404C File Offset: 0x0009224C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500906, XrefRangeEnd = 500910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnInstantiateComplete_b__4_0(FriendChatView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListChatReopener.__c.NativeMethodInfoPtr__OnInstantiateComplete_b__4_0_Internal_Boolean_FriendChatView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060023F0 RID: 9200 RVA: 0x0009409C File Offset: 0x0009229C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500910, XrefRangeEnd = 500914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<FriendChatResponder> _OnInstantiateComplete_b__4_1(ProviderInstantiator p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListChatReopener.__c.NativeMethodInfoPtr__OnInstantiateComplete_b__4_1_Internal_IEnumerable_1_FriendChatResponder_ProviderInstantiator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FriendChatResponder>>(intPtr3) : null;
				}
			}

			// Token: 0x060023F1 RID: 9201 RVA: 0x00012B06 File Offset: 0x00010D06
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009C8 RID: 2504
			// (get) Token: 0x060023F2 RID: 9202 RVA: 0x000940EC File Offset: 0x000922EC
			// (set) Token: 0x060023F3 RID: 9203 RVA: 0x00012B0F File Offset: 0x00010D0F
			public unsafe static FriendsListChatReopener.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsListChatReopener.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListChatReopener.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsListChatReopener.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x060023F4 RID: 9204 RVA: 0x00094114 File Offset: 0x00092314
			// (set) Token: 0x060023F5 RID: 9205 RVA: 0x00012B21 File Offset: 0x00010D21
			public unsafe static Predicate<FriendChatView> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsListChatReopener.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<FriendChatView>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsListChatReopener.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x060023F6 RID: 9206 RVA: 0x0009413C File Offset: 0x0009233C
			// (set) Token: 0x060023F7 RID: 9207 RVA: 0x00012B33 File Offset: 0x00010D33
			public unsafe static Func<ProviderInstantiator, IEnumerable<FriendChatResponder>> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsListChatReopener.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProviderInstantiator, IEnumerable<FriendChatResponder>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsListChatReopener.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001692 RID: 5778
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001693 RID: 5779
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001694 RID: 5780
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04001695 RID: 5781
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001696 RID: 5782
			private static readonly IntPtr NativeMethodInfoPtr__OnInstantiateComplete_b__4_0_Internal_Boolean_FriendChatView_0;

			// Token: 0x04001697 RID: 5783
			private static readonly IntPtr NativeMethodInfoPtr__OnInstantiateComplete_b__4_1_Internal_IEnumerable_1_FriendChatResponder_ProviderInstantiator_0;
		}

		// Token: 0x020002FA RID: 762
		[ObfuscatedName("dwd.canis.dbg_client.dataRenderers.FriendsListChatReopener+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023F8 RID: 9208 RVA: 0x00094164 File Offset: 0x00092364
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<FriendsListChatReopener.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendsListChatReopener>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListChatReopener.__c__DisplayClass4_0>.NativeClassPtr);
				FriendsListChatReopener.__c__DisplayClass4_0.NativeFieldInfoPtr_friendChatResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListChatReopener.__c__DisplayClass4_0>.NativeClassPtr, "friendChatResponder");
				FriendsListChatReopener.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListChatReopener.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				FriendsListChatReopener.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListChatReopener.__c__DisplayClass4_0>.NativeClassPtr, 100664007);
				FriendsListChatReopener.__c__DisplayClass4_0.NativeMethodInfoPtr__OnInstantiateComplete_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListChatReopener.__c__DisplayClass4_0>.NativeClassPtr, 100664008);
				FriendsListChatReopener.__c__DisplayClass4_0.NativeMethodInfoPtr__OnInstantiateComplete_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListChatReopener.__c__DisplayClass4_0>.NativeClassPtr, 100664009);
			}

			// Token: 0x060023F9 RID: 9209 RVA: 0x000941F4 File Offset: 0x000923F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListChatReopener.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListChatReopener.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023FA RID: 9210 RVA: 0x00094230 File Offset: 0x00092430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500914, XrefRangeEnd = 500917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInstantiateComplete_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListChatReopener.__c__DisplayClass4_0.NativeMethodInfoPtr__OnInstantiateComplete_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023FB RID: 9211 RVA: 0x00094264 File Offset: 0x00092464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500917, XrefRangeEnd = 500924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInstantiateComplete_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListChatReopener.__c__DisplayClass4_0.NativeMethodInfoPtr__OnInstantiateComplete_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023FC RID: 9212 RVA: 0x00012B45 File Offset: 0x00010D45
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009CB RID: 2507
			// (get) Token: 0x060023FD RID: 9213 RVA: 0x00094298 File Offset: 0x00092498
			// (set) Token: 0x060023FE RID: 9214 RVA: 0x00012B4E File Offset: 0x00010D4E
			public unsafe FriendChatResponder friendChatResponder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.__c__DisplayClass4_0.NativeFieldInfoPtr_friendChatResponder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendChatResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.__c__DisplayClass4_0.NativeFieldInfoPtr_friendChatResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009CC RID: 2508
			// (get) Token: 0x060023FF RID: 9215 RVA: 0x000942C8 File Offset: 0x000924C8
			// (set) Token: 0x06002400 RID: 9216 RVA: 0x00012B6D File Offset: 0x00010D6D
			public unsafe FriendsListChatReopener __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsListChatReopener>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListChatReopener.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001698 RID: 5784
			private static readonly IntPtr NativeFieldInfoPtr_friendChatResponder;

			// Token: 0x04001699 RID: 5785
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400169A RID: 5786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400169B RID: 5787
			private static readonly IntPtr NativeMethodInfoPtr__OnInstantiateComplete_b__2_Internal_Void_0;

			// Token: 0x0400169C RID: 5788
			private static readonly IntPtr NativeMethodInfoPtr__OnInstantiateComplete_b__3_Internal_Void_0;
		}
	}
}
