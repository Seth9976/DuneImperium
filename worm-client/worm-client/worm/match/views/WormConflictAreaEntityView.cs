using System;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;

namespace worm.match.views
{
	// Token: 0x020000AA RID: 170
	public class WormConflictAreaEntityView : EntityView
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x0002CA50 File Offset: 0x0002AC50
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictAreaEntityView()
		{
			Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.views", "WormConflictAreaEntityView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr);
			WormConflictAreaEntityView.NativeFieldInfoPtr_player1ConflictViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, "player1ConflictViews");
			WormConflictAreaEntityView.NativeFieldInfoPtr_player2ConflictViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, "player2ConflictViews");
			WormConflictAreaEntityView.NativeFieldInfoPtr_player3ConflictViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, "player3ConflictViews");
			WormConflictAreaEntityView.NativeFieldInfoPtr_player4ConflictViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, "player4ConflictViews");
			WormConflictAreaEntityView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, 100664215);
			WormConflictAreaEntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, 100664216);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0002CAF8 File Offset: 0x0002ACF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696542, XrefRangeEnd = 696632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityComponent ec, EntityView p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictAreaEntityView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0002CB58 File Offset: 0x0002AD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696632, XrefRangeEnd = 696633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictAreaEntityView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAreaEntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00005485 File Offset: 0x00003685
		public WormConflictAreaEntityView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0002CB94 File Offset: 0x0002AD94
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x0000548E File Offset: 0x0000368E
		public unsafe WormConflictAreaEntityView.PlayerConflictArea player1ConflictViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.NativeFieldInfoPtr_player1ConflictViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictAreaEntityView.PlayerConflictArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.NativeFieldInfoPtr_player1ConflictViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0002CBC4 File Offset: 0x0002ADC4
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x000054AD File Offset: 0x000036AD
		public unsafe WormConflictAreaEntityView.PlayerConflictArea player2ConflictViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.NativeFieldInfoPtr_player2ConflictViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictAreaEntityView.PlayerConflictArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.NativeFieldInfoPtr_player2ConflictViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0002CBF4 File Offset: 0x0002ADF4
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x000054CC File Offset: 0x000036CC
		public unsafe WormConflictAreaEntityView.PlayerConflictArea player3ConflictViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.NativeFieldInfoPtr_player3ConflictViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictAreaEntityView.PlayerConflictArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.NativeFieldInfoPtr_player3ConflictViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0002CC24 File Offset: 0x0002AE24
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x000054EB File Offset: 0x000036EB
		public unsafe WormConflictAreaEntityView.PlayerConflictArea player4ConflictViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.NativeFieldInfoPtr_player4ConflictViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictAreaEntityView.PlayerConflictArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.NativeFieldInfoPtr_player4ConflictViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_player1ConflictViews;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_player2ConflictViews;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_player3ConflictViews;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_player4ConflictViews;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200030D RID: 781
		[Serializable]
		public class PlayerConflictArea : Object
		{
			// Token: 0x06001F89 RID: 8073 RVA: 0x000787E4 File Offset: 0x000769E4
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerConflictArea()
			{
				Il2CppClassPointerStore<WormConflictAreaEntityView.PlayerConflictArea>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, "PlayerConflictArea");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAreaEntityView.PlayerConflictArea>.NativeClassPtr);
				WormConflictAreaEntityView.PlayerConflictArea.NativeFieldInfoPtr_Garrison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAreaEntityView.PlayerConflictArea>.NativeClassPtr, "Garrison");
				WormConflictAreaEntityView.PlayerConflictArea.NativeFieldInfoPtr_Deployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAreaEntityView.PlayerConflictArea>.NativeClassPtr, "Deployed");
				WormConflictAreaEntityView.PlayerConflictArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView.PlayerConflictArea>.NativeClassPtr, 100664217);
			}

			// Token: 0x06001F8A RID: 8074 RVA: 0x0007884C File Offset: 0x00076A4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerConflictArea()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAreaEntityView.PlayerConflictArea>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAreaEntityView.PlayerConflictArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F8B RID: 8075 RVA: 0x00011C8C File Offset: 0x0000FE8C
			public PlayerConflictArea(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00078888 File Offset: 0x00076A88
			// (set) Token: 0x06001F8D RID: 8077 RVA: 0x00011C95 File Offset: 0x0000FE95
			public unsafe EntityView Garrison
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.PlayerConflictArea.NativeFieldInfoPtr_Garrison);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.PlayerConflictArea.NativeFieldInfoPtr_Garrison), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06001F8E RID: 8078 RVA: 0x000788B8 File Offset: 0x00076AB8
			// (set) Token: 0x06001F8F RID: 8079 RVA: 0x00011CB4 File Offset: 0x0000FEB4
			public unsafe EntityView Deployed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.PlayerConflictArea.NativeFieldInfoPtr_Deployed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.PlayerConflictArea.NativeFieldInfoPtr_Deployed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400123A RID: 4666
			private static readonly IntPtr NativeFieldInfoPtr_Garrison;

			// Token: 0x0400123B RID: 4667
			private static readonly IntPtr NativeFieldInfoPtr_Deployed;

			// Token: 0x0400123C RID: 4668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200030E RID: 782
		[ObfuscatedName("worm.match.views.WormConflictAreaEntityView+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06001F90 RID: 8080 RVA: 0x000788E8 File Offset: 0x00076AE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_0>.NativeClassPtr);
				WormConflictAreaEntityView.__c__DisplayClass5_0.NativeFieldInfoPtr_ec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_0>.NativeClassPtr, "ec");
				WormConflictAreaEntityView.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_0>.NativeClassPtr, 100664218);
				WormConflictAreaEntityView.__c__DisplayClass5_0.NativeMethodInfoPtr__Init_b__0_Internal_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_0>.NativeClassPtr, 100664219);
			}

			// Token: 0x06001F91 RID: 8081 RVA: 0x00078950 File Offset: 0x00076B50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAreaEntityView.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F92 RID: 8082 RVA: 0x0007898C File Offset: 0x00076B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696508, XrefRangeEnd = 696523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__0(AccountID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAreaEntityView.__c__DisplayClass5_0.NativeMethodInfoPtr__Init_b__0_Internal_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F93 RID: 8083 RVA: 0x00011CD3 File Offset: 0x0000FED3
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x06001F94 RID: 8084 RVA: 0x000789DC File Offset: 0x00076BDC
			// (set) Token: 0x06001F95 RID: 8085 RVA: 0x00011CDC File Offset: 0x0000FEDC
			public unsafe EntityComponent ec
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.__c__DisplayClass5_0.NativeFieldInfoPtr_ec);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.__c__DisplayClass5_0.NativeFieldInfoPtr_ec), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400123D RID: 4669
			private static readonly IntPtr NativeFieldInfoPtr_ec;

			// Token: 0x0400123E RID: 4670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400123F RID: 4671
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__0_Internal_Boolean_AccountID_0;
		}

		// Token: 0x0200030F RID: 783
		[ObfuscatedName("worm.match.views.WormConflictAreaEntityView+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Object
		{
			// Token: 0x06001F96 RID: 8086 RVA: 0x00078A0C File Offset: 0x00076C0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_1>.NativeClassPtr);
				WormConflictAreaEntityView.__c__DisplayClass5_1.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_1>.NativeClassPtr, "id");
				WormConflictAreaEntityView.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_1>.NativeClassPtr, 100664220);
				WormConflictAreaEntityView.__c__DisplayClass5_1.NativeMethodInfoPtr__Init_b__1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_1>.NativeClassPtr, 100664221);
			}

			// Token: 0x06001F97 RID: 8087 RVA: 0x00078A74 File Offset: 0x00076C74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAreaEntityView.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F98 RID: 8088 RVA: 0x00078AB0 File Offset: 0x00076CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696523, XrefRangeEnd = 696528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__1(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAreaEntityView.__c__DisplayClass5_1.NativeMethodInfoPtr__Init_b__1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F99 RID: 8089 RVA: 0x00011CFB File Offset: 0x0000FEFB
			public __c__DisplayClass5_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00078B00 File Offset: 0x00076D00
			// (set) Token: 0x06001F9B RID: 8091 RVA: 0x00011D04 File Offset: 0x0000FF04
			public unsafe AccountID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.__c__DisplayClass5_1.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.__c__DisplayClass5_1.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001240 RID: 4672
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04001241 RID: 4673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001242 RID: 4674
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__1_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000310 RID: 784
		[ObfuscatedName("worm.match.views.WormConflictAreaEntityView+<>c__DisplayClass5_2")]
		public sealed class __c__DisplayClass5_2 : Object
		{
			// Token: 0x06001F9C RID: 8092 RVA: 0x00078B30 File Offset: 0x00076D30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_2()
			{
				Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictAreaEntityView>.NativeClassPtr, "<>c__DisplayClass5_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_2>.NativeClassPtr);
				WormConflictAreaEntityView.__c__DisplayClass5_2.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_2>.NativeClassPtr, "accountID");
				WormConflictAreaEntityView.__c__DisplayClass5_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_2>.NativeClassPtr, 100664222);
				WormConflictAreaEntityView.__c__DisplayClass5_2.NativeMethodInfoPtr__Init_b__2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_2>.NativeClassPtr, 100664223);
				WormConflictAreaEntityView.__c__DisplayClass5_2.NativeMethodInfoPtr__Init_b__3_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_2>.NativeClassPtr, 100664224);
			}

			// Token: 0x06001F9D RID: 8093 RVA: 0x00078BAC File Offset: 0x00076DAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAreaEntityView.__c__DisplayClass5_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAreaEntityView.__c__DisplayClass5_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F9E RID: 8094 RVA: 0x00078BE8 File Offset: 0x00076DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696528, XrefRangeEnd = 696535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__2(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAreaEntityView.__c__DisplayClass5_2.NativeMethodInfoPtr__Init_b__2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F9F RID: 8095 RVA: 0x00078C38 File Offset: 0x00076E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696535, XrefRangeEnd = 696542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__3(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAreaEntityView.__c__DisplayClass5_2.NativeMethodInfoPtr__Init_b__3_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FA0 RID: 8096 RVA: 0x00011D23 File Offset: 0x0000FF23
			public __c__DisplayClass5_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x00078C88 File Offset: 0x00076E88
			// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x00011D2C File Offset: 0x0000FF2C
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.__c__DisplayClass5_2.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAreaEntityView.__c__DisplayClass5_2.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001243 RID: 4675
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04001244 RID: 4676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001245 RID: 4677
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__2_Internal_Boolean_EntityComponent_0;

			// Token: 0x04001246 RID: 4678
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__3_Internal_Boolean_EntityComponent_0;
		}
	}
}
