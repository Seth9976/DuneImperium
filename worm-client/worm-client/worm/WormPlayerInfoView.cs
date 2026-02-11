using System;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lib.canis.boardgames.src.match;
using lotus;
using UnityEngine.UI;
using worm.match.data;

namespace worm
{
	// Token: 0x02000046 RID: 70
	public class WormPlayerInfoView : EntityView
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x00021EF0 File Offset: 0x000200F0
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerInfoView()
		{
			Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormPlayerInfoView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr);
			WormPlayerInfoView.NativeFieldInfoPtr_deckView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "deckView");
			WormPlayerInfoView.NativeFieldInfoPtr_discardView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "discardView");
			WormPlayerInfoView.NativeFieldInfoPtr_playAreaView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "playAreaView");
			WormPlayerInfoView.NativeFieldInfoPtr_trashView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "trashView");
			WormPlayerInfoView.NativeFieldInfoPtr_techView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "techView");
			WormPlayerInfoView.NativeFieldInfoPtr_discardToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "discardToggle");
			WormPlayerInfoView.NativeFieldInfoPtr_playAreaToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "playAreaToggle");
			WormPlayerInfoView.NativeFieldInfoPtr_deckToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "deckToggle");
			WormPlayerInfoView.NativeFieldInfoPtr_trashToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "trashToggle");
			WormPlayerInfoView.NativeFieldInfoPtr_techToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "techToggle");
			WormPlayerInfoView.NativeFieldInfoPtr_piles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "piles");
			WormPlayerInfoView.NativeFieldInfoPtr_tempEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "tempEntities");
			WormPlayerInfoView.NativeMethodInfoPtr_Init_Public_Void_EntityComponent_EntityView_Boolean_WormPlayerInfoViewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663777);
			WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowDeck_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663778);
			WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowDiscard_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663779);
			WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowPlayArea_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663780);
			WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowTrash_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663781);
			WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowTech_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663782);
			WormPlayerInfoView.NativeMethodInfoPtr_ShowPile_Private_Void_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663783);
			WormPlayerInfoView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663784);
			WormPlayerInfoView.NativeMethodInfoPtr_GetPile_Private_EntityComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663785);
			WormPlayerInfoView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663786);
			WormPlayerInfoView.NativeMethodInfoPtr_Method_Private_List_1_EntityComponent_List_1_ArchetypeID_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, 100663787);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000220EC File Offset: 0x000202EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 691254, RefRangeEnd = 691256, XrefRangeStart = 690929, XrefRangeEnd = 691254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(EntityComponent ec, EntityView p, bool isLocalPlayer, WormPlayerInfoViewType openView = WormPlayerInfoViewType.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocalPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openView;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr_Init_Public_Void_EntityComponent_EntityView_Boolean_WormPlayerInfoViewType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0002215C File Offset: 0x0002035C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691256, XrefRangeEnd = 691257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowDeck(bool doShow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref doShow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowDeck_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0002219C File Offset: 0x0002039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691257, XrefRangeEnd = 691258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowDiscard(bool doShow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref doShow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowDiscard_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000221DC File Offset: 0x000203DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691258, XrefRangeEnd = 691259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowPlayArea(bool doShow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref doShow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowPlayArea_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0002221C File Offset: 0x0002041C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691259, XrefRangeEnd = 691260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowTrash(bool doShow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref doShow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowTrash_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0002225C File Offset: 0x0002045C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691260, XrefRangeEnd = 691261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowTech(bool doShow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref doShow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr_Event_ShowTech_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0002229C File Offset: 0x0002049C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 691284, RefRangeEnd = 691289, XrefRangeStart = 691261, XrefRangeEnd = 691284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowPile(ContainerView pile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr_ShowPile_Private_Void_ContainerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000222E0 File Offset: 0x000204E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691289, XrefRangeEnd = 691311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDespawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerInfoView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00022330 File Offset: 0x00020530
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 691326, RefRangeEnd = 691331, XrefRangeStart = 691311, XrefRangeEnd = 691326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent GetPile(string entityName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr_GetPile_Private_EntityComponent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00022380 File Offset: 0x00020580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691331, XrefRangeEnd = 691343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerInfoView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000223BC File Offset: 0x000205BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 691372, RefRangeEnd = 691374, XrefRangeStart = 691343, XrefRangeEnd = 691372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EntityComponent> Method_Private_List_1_EntityComponent_List_1_ArchetypeID_byref___c__DisplayClass12_0_0(List<ArchetypeID> archetypeIds, ref WormPlayerInfoView.__c__DisplayClass12_0 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeIds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.NativeMethodInfoPtr_Method_Private_List_1_EntityComponent_List_1_ArchetypeID_byref___c__DisplayClass12_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr3) : null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000035B9 File Offset: 0x000017B9
		public WormPlayerInfoView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00022420 File Offset: 0x00020620
		// (set) Token: 0x06000302 RID: 770 RVA: 0x000035C2 File Offset: 0x000017C2
		public unsafe ContainerView deckView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_deckView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_deckView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00022450 File Offset: 0x00020650
		// (set) Token: 0x06000304 RID: 772 RVA: 0x000035E1 File Offset: 0x000017E1
		public unsafe ContainerView discardView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_discardView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_discardView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00022480 File Offset: 0x00020680
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00003600 File Offset: 0x00001800
		public unsafe ContainerView playAreaView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_playAreaView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_playAreaView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000307 RID: 775 RVA: 0x000224B0 File Offset: 0x000206B0
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0000361F File Offset: 0x0000181F
		public unsafe ContainerView trashView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_trashView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_trashView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000224E0 File Offset: 0x000206E0
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000363E File Offset: 0x0000183E
		public unsafe ContainerView techView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_techView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_techView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00022510 File Offset: 0x00020710
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000365D File Offset: 0x0000185D
		public unsafe Toggle discardToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_discardToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_discardToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00022540 File Offset: 0x00020740
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000367C File Offset: 0x0000187C
		public unsafe Toggle playAreaToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_playAreaToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_playAreaToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00022570 File Offset: 0x00020770
		// (set) Token: 0x06000310 RID: 784 RVA: 0x0000369B File Offset: 0x0000189B
		public unsafe Toggle deckToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_deckToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_deckToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000225A0 File Offset: 0x000207A0
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000036BA File Offset: 0x000018BA
		public unsafe Toggle trashToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_trashToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_trashToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000313 RID: 787 RVA: 0x000225D0 File Offset: 0x000207D0
		// (set) Token: 0x06000314 RID: 788 RVA: 0x000036D9 File Offset: 0x000018D9
		public unsafe Toggle techToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_techToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_techToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00022600 File Offset: 0x00020800
		// (set) Token: 0x06000316 RID: 790 RVA: 0x000036F8 File Offset: 0x000018F8
		public unsafe IReadOnlyList<ContainerView> piles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_piles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ContainerView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_piles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00022630 File Offset: 0x00020830
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00003717 File Offset: 0x00001917
		public unsafe List<EntityComponent> tempEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_tempEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.NativeFieldInfoPtr_tempEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_deckView;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_discardView;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_playAreaView;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_trashView;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_techView;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_discardToggle;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_playAreaToggle;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_deckToggle;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_trashToggle;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_techToggle;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_piles;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_tempEntities;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_EntityComponent_EntityView_Boolean_WormPlayerInfoViewType_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowDeck_Public_Void_Boolean_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowDiscard_Public_Void_Boolean_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowPlayArea_Public_Void_Boolean_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowTrash_Public_Void_Boolean_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowTech_Public_Void_Boolean_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_ShowPile_Private_Void_ContainerView_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_GetPile_Private_EntityComponent_String_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_List_1_EntityComponent_List_1_ArchetypeID_byref___c__DisplayClass12_0_0;

		// Token: 0x020002E0 RID: 736
		[ObfuscatedName("worm.WormPlayerInfoView+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DF1 RID: 7665 RVA: 0x00073E1C File Offset: 0x0007201C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormPlayerInfoView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoView.__c>.NativeClassPtr);
				WormPlayerInfoView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView.__c>.NativeClassPtr, "<>9");
				WormPlayerInfoView.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView.__c>.NativeClassPtr, "<>9__12_0");
				WormPlayerInfoView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView.__c>.NativeClassPtr, 100663789);
				WormPlayerInfoView.__c.NativeMethodInfoPtr__Init_b__12_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView.__c>.NativeClassPtr, 100663790);
			}

			// Token: 0x06001DF2 RID: 7666 RVA: 0x00073E98 File Offset: 0x00072098
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoView.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DF3 RID: 7667 RVA: 0x00073ED4 File Offset: 0x000720D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690920, XrefRangeEnd = 690927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__12_0(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.__c.NativeMethodInfoPtr__Init_b__12_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DF4 RID: 7668 RVA: 0x000110E9 File Offset: 0x0000F2E9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000836 RID: 2102
			// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x00073F24 File Offset: 0x00072124
			// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x000110F2 File Offset: 0x0000F2F2
			public unsafe static WormPlayerInfoView.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayerInfoView.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerInfoView.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayerInfoView.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000837 RID: 2103
			// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00073F4C File Offset: 0x0007214C
			// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x00011104 File Offset: 0x0000F304
			public unsafe static Func<EntityComponent, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayerInfoView.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayerInfoView.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400115C RID: 4444
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400115D RID: 4445
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x0400115E RID: 4446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400115F RID: 4447
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__12_0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x020002E1 RID: 737
		[ObfuscatedName("worm.WormPlayerInfoView+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : ValueType
		{
			// Token: 0x06001DF9 RID: 7673 RVA: 0x00073F74 File Offset: 0x00072174
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass12_0>.NativeClassPtr);
				WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr_archetypeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass12_0>.NativeClassPtr, "archetypeProvider");
				WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr_wormEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass12_0>.NativeClassPtr, "wormEntities");
				WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr_ec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass12_0>.NativeClassPtr, "ec");
				WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
			}

			// Token: 0x06001DFA RID: 7674 RVA: 0x00011116 File Offset: 0x0000F316
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001DFB RID: 7675 RVA: 0x0001111F File Offset: 0x0000F31F
			public __c__DisplayClass12_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass12_0>.NativeClassPtr))
			{
			}

			// Token: 0x17000838 RID: 2104
			// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00073FF0 File Offset: 0x000721F0
			// (set) Token: 0x06001DFD RID: 7677 RVA: 0x00011131 File Offset: 0x0000F331
			public unsafe ArchetypeProvider archetypeProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr_archetypeProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr_archetypeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000839 RID: 2105
			// (get) Token: 0x06001DFE RID: 7678 RVA: 0x00074020 File Offset: 0x00072220
			// (set) Token: 0x06001DFF RID: 7679 RVA: 0x00011150 File Offset: 0x0000F350
			public unsafe WormEntities wormEntities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr_wormEntities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr_wormEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083A RID: 2106
			// (get) Token: 0x06001E00 RID: 7680 RVA: 0x00074050 File Offset: 0x00072250
			// (set) Token: 0x06001E01 RID: 7681 RVA: 0x0001116F File Offset: 0x0000F36F
			public unsafe EntityComponent ec
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr_ec);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr_ec), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083B RID: 2107
			// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00074080 File Offset: 0x00072280
			// (set) Token: 0x06001E03 RID: 7683 RVA: 0x0001118E File Offset: 0x0000F38E
			public unsafe WormPlayerInfoView __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerInfoView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001160 RID: 4448
			private static readonly IntPtr NativeFieldInfoPtr_archetypeProvider;

			// Token: 0x04001161 RID: 4449
			private static readonly IntPtr NativeFieldInfoPtr_wormEntities;

			// Token: 0x04001162 RID: 4450
			private static readonly IntPtr NativeFieldInfoPtr_ec;

			// Token: 0x04001163 RID: 4451
			private static readonly IntPtr NativeFieldInfoPtr___4__this;
		}

		// Token: 0x020002E2 RID: 738
		[ObfuscatedName("worm.WormPlayerInfoView+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x06001E04 RID: 7684 RVA: 0x000740B0 File Offset: 0x000722B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerInfoView>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass20_0>.NativeClassPtr);
				WormPlayerInfoView.__c__DisplayClass20_0.NativeFieldInfoPtr_entityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass20_0>.NativeClassPtr, "entityName");
				WormPlayerInfoView.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass20_0>.NativeClassPtr, 100663791);
				WormPlayerInfoView.__c__DisplayClass20_0.NativeMethodInfoPtr__GetPile_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass20_0>.NativeClassPtr, 100663792);
			}

			// Token: 0x06001E05 RID: 7685 RVA: 0x00074118 File Offset: 0x00072318
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerInfoView.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E06 RID: 7686 RVA: 0x00074154 File Offset: 0x00072354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690927, XrefRangeEnd = 690929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPile_b__0(EntityComponent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerInfoView.__c__DisplayClass20_0.NativeMethodInfoPtr__GetPile_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E07 RID: 7687 RVA: 0x000111AD File Offset: 0x0000F3AD
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700083C RID: 2108
			// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000741A4 File Offset: 0x000723A4
			// (set) Token: 0x06001E09 RID: 7689 RVA: 0x000111B6 File Offset: 0x0000F3B6
			public unsafe string entityName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass20_0.NativeFieldInfoPtr_entityName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerInfoView.__c__DisplayClass20_0.NativeFieldInfoPtr_entityName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001164 RID: 4452
			private static readonly IntPtr NativeFieldInfoPtr_entityName;

			// Token: 0x04001165 RID: 4453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001166 RID: 4454
			private static readonly IntPtr NativeMethodInfoPtr__GetPile_b__0_Internal_Boolean_EntityComponent_0;
		}
	}
}
