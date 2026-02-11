using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x0200007F RID: 127
	public class UnitView : EntityView
	{
		// Token: 0x06000770 RID: 1904 RVA: 0x00021F34 File Offset: 0x00020134
		// Note: this type is marked as 'beforefieldinit'.
		static UnitView()
		{
			Il2CppClassPointerStore<UnitView>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "UnitView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitView>.NativeClassPtr);
			UnitView.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView>.NativeClassPtr, "positions");
			UnitView.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView>.NativeClassPtr, "up");
			UnitView.NativeFieldInfoPtr_currentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView>.NativeClassPtr, "currentPosition");
			UnitView.NativeFieldInfoPtr_OnPositionRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView>.NativeClassPtr, "OnPositionRequested");
			UnitView.NativeFieldInfoPtr_OnPositionRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView>.NativeClassPtr, "OnPositionRemoved");
			UnitView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664296);
			UnitView.NativeMethodInfoPtr_Regenerate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664297);
			UnitView.NativeMethodInfoPtr_AddPosition_Public_Virtual_New_Void_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664298);
			UnitView.NativeMethodInfoPtr_RemovePosition_Public_Virtual_New_Void_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664299);
			UnitView.NativeMethodInfoPtr_GetPosition_Public_UnitPosition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664300);
			UnitView.NativeMethodInfoPtr_HasPosition_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664301);
			UnitView.NativeMethodInfoPtr_HasPosition_Public_Boolean_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664302);
			UnitView.NativeMethodInfoPtr_RemovePositionForRequester_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664303);
			UnitView.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664304);
			UnitView.NativeMethodInfoPtr_refreshPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664305);
			UnitView.NativeMethodInfoPtr_GetPositionInfo_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664306);
			UnitView.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664307);
			UnitView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664308);
			UnitView.NativeMethodInfoPtr_UnparentAndDespawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664309);
			UnitView.NativeMethodInfoPtr_AllowPositionReinitialization_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664310);
			UnitView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView>.NativeClassPtr, 100664311);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00022108 File Offset: 0x00020308
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1114325, RefRangeEnd = 1114330, XrefRangeStart = 1114300, XrefRangeEnd = 1114325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00022168 File Offset: 0x00020368
		[CallerCount(0)]
		public unsafe void Regenerate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.NativeMethodInfoPtr_Regenerate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0002219C File Offset: 0x0002039C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1114342, RefRangeEnd = 1114343, XrefRangeStart = 1114330, XrefRangeEnd = 1114342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddPosition(UnitPosition position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitView.NativeMethodInfoPtr_AddPosition_Public_Virtual_New_Void_UnitPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000221EC File Offset: 0x000203EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1114351, RefRangeEnd = 1114352, XrefRangeStart = 1114343, XrefRangeEnd = 1114351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemovePosition(UnitPosition position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitView.NativeMethodInfoPtr_RemovePosition_Public_Virtual_New_Void_UnitPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0002223C File Offset: 0x0002043C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1114373, RefRangeEnd = 1114375, XrefRangeStart = 1114352, XrefRangeEnd = 1114373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitPosition GetPosition(int moveLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.NativeMethodInfoPtr_GetPosition_Public_UnitPosition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr3) : null;
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00022288 File Offset: 0x00020488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114375, XrefRangeEnd = 1114389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPosition(int moveLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.NativeMethodInfoPtr_HasPosition_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000222D4 File Offset: 0x000204D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114389, XrefRangeEnd = 1114404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPosition(UnitPosition unitPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unitPosition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.NativeMethodInfoPtr_HasPosition_Public_Boolean_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00022324 File Offset: 0x00020524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1114423, RefRangeEnd = 1114424, XrefRangeStart = 1114404, XrefRangeEnd = 1114423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePositionForRequester(Object requester)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requester);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.NativeMethodInfoPtr_RemovePositionForRequester_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00022368 File Offset: 0x00020568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114424, XrefRangeEnd = 1114426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePosition(UnitPosition position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitView.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_UnitPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000223B8 File Offset: 0x000205B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1114447, RefRangeEnd = 1114449, XrefRangeStart = 1114426, XrefRangeEnd = 1114447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void refreshPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.NativeMethodInfoPtr_refreshPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000223EC File Offset: 0x000205EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114449, XrefRangeEnd = 1114504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPositionInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.NativeMethodInfoPtr_GetPositionInfo_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00022424 File Offset: 0x00020624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1114523, RefRangeEnd = 1114524, XrefRangeStart = 1114504, XrefRangeEnd = 1114523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitView.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00022460 File Offset: 0x00020660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1114534, RefRangeEnd = 1114535, XrefRangeStart = 1114524, XrefRangeEnd = 1114534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDespawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000224B0 File Offset: 0x000206B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1114541, RefRangeEnd = 1114545, XrefRangeStart = 1114535, XrefRangeEnd = 1114541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnparentAndDespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.NativeMethodInfoPtr_UnparentAndDespawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000224E4 File Offset: 0x000206E4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AllowPositionReinitialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitView.NativeMethodInfoPtr_AllowPositionReinitialization_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0002252C File Offset: 0x0002072C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1114566, RefRangeEnd = 1114571, XrefRangeStart = 1114545, XrefRangeEnd = 1114566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00005B36 File Offset: 0x00003D36
		public UnitView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00022568 File Offset: 0x00020768
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00005B3F File Offset: 0x00003D3F
		public unsafe List<UnitPosition> positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitPosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00022598 File Offset: 0x00020798
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00005B5E File Offset: 0x00003D5E
		public unsafe UnitPosition up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_up);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_up), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000225C8 File Offset: 0x000207C8
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00005B7D File Offset: 0x00003D7D
		public unsafe UnitPosition currentPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_currentPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_currentPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x000225F8 File Offset: 0x000207F8
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00005B9C File Offset: 0x00003D9C
		public unsafe OnPositionRequestedEvent OnPositionRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_OnPositionRequested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnPositionRequestedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_OnPositionRequested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00022628 File Offset: 0x00020828
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00005BBB File Offset: 0x00003DBB
		public unsafe OnPositionRequestedEvent OnPositionRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_OnPositionRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnPositionRequestedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.NativeFieldInfoPtr_OnPositionRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_currentPosition;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr_OnPositionRequested;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeFieldInfoPtr_OnPositionRemoved;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_Regenerate_Public_Void_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_AddPosition_Public_Virtual_New_Void_UnitPosition_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_RemovePosition_Public_Virtual_New_Void_UnitPosition_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Public_UnitPosition_Int32_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_HasPosition_Public_Boolean_Int32_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_HasPosition_Public_Boolean_UnitPosition_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_RemovePositionForRequester_Public_Void_Object_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_UnitPosition_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_refreshPosition_Private_Void_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionInfo_Public_String_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_UnparentAndDespawn_Public_Void_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_AllowPositionReinitialization_Public_Virtual_New_Boolean_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000F9 RID: 249
		[ObfuscatedName("lotus.UnitView+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000CC8 RID: 3272 RVA: 0x00032B54 File Offset: 0x00030D54
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnitView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitView>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitView.__c>.NativeClassPtr);
				UnitView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView.__c>.NativeClassPtr, "<>9");
				UnitView.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView.__c>.NativeClassPtr, "<>9__15_0");
				UnitView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView.__c>.NativeClassPtr, 100664313);
				UnitView.__c.NativeMethodInfoPtr__GetPositionInfo_b__15_0_Internal_Int32_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView.__c>.NativeClassPtr, 100664314);
			}

			// Token: 0x06000CC9 RID: 3273 RVA: 0x00032BD0 File Offset: 0x00030DD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitView.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CCA RID: 3274 RVA: 0x00032C0C File Offset: 0x00030E0C
			[CallerCount(0)]
			public unsafe int _GetPositionInfo_b__15_0(UnitPosition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.__c.NativeMethodInfoPtr__GetPositionInfo_b__15_0_Internal_Int32_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CCB RID: 3275 RVA: 0x000084F6 File Offset: 0x000066F6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003C7 RID: 967
			// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00032C5C File Offset: 0x00030E5C
			// (set) Token: 0x06000CCD RID: 3277 RVA: 0x000084FF File Offset: 0x000066FF
			public unsafe static UnitView.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnitView.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnitView.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003C8 RID: 968
			// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00032C84 File Offset: 0x00030E84
			// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00008511 File Offset: 0x00006711
			public unsafe static Func<UnitPosition, int> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnitView.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UnitPosition, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnitView.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040007F4 RID: 2036
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040007F5 RID: 2037
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040007F6 RID: 2038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040007F7 RID: 2039
			private static readonly IntPtr NativeMethodInfoPtr__GetPositionInfo_b__15_0_Internal_Int32_UnitPosition_0;
		}

		// Token: 0x020000FA RID: 250
		[ObfuscatedName("lotus.UnitView+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06000CD0 RID: 3280 RVA: 0x00032CAC File Offset: 0x00030EAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<UnitView.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitView>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitView.__c__DisplayClass10_0>.NativeClassPtr);
				UnitView.__c__DisplayClass10_0.NativeFieldInfoPtr_moveLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView.__c__DisplayClass10_0>.NativeClassPtr, "moveLayer");
				UnitView.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView.__c__DisplayClass10_0>.NativeClassPtr, 100664315);
				UnitView.__c__DisplayClass10_0.NativeMethodInfoPtr__HasPosition_b__0_Internal_Boolean_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView.__c__DisplayClass10_0>.NativeClassPtr, 100664316);
			}

			// Token: 0x06000CD1 RID: 3281 RVA: 0x00032D14 File Offset: 0x00030F14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitView.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CD2 RID: 3282 RVA: 0x00032D50 File Offset: 0x00030F50
			[CallerCount(0)]
			public unsafe bool _HasPosition_b__0(UnitPosition position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.__c__DisplayClass10_0.NativeMethodInfoPtr__HasPosition_b__0_Internal_Boolean_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CD3 RID: 3283 RVA: 0x00008523 File Offset: 0x00006723
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003C9 RID: 969
			// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00032DA0 File Offset: 0x00030FA0
			// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x0000852C File Offset: 0x0000672C
			public unsafe int moveLayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.__c__DisplayClass10_0.NativeFieldInfoPtr_moveLayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.__c__DisplayClass10_0.NativeFieldInfoPtr_moveLayer)) = value;
				}
			}

			// Token: 0x040007F8 RID: 2040
			private static readonly IntPtr NativeFieldInfoPtr_moveLayer;

			// Token: 0x040007F9 RID: 2041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040007FA RID: 2042
			private static readonly IntPtr NativeMethodInfoPtr__HasPosition_b__0_Internal_Boolean_UnitPosition_0;
		}

		// Token: 0x020000FB RID: 251
		[ObfuscatedName("lotus.UnitView+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06000CD6 RID: 3286 RVA: 0x00032DC8 File Offset: 0x00030FC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<UnitView.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitView>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitView.__c__DisplayClass11_0>.NativeClassPtr);
				UnitView.__c__DisplayClass11_0.NativeFieldInfoPtr_unitPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView.__c__DisplayClass11_0>.NativeClassPtr, "unitPosition");
				UnitView.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView.__c__DisplayClass11_0>.NativeClassPtr, 100664317);
				UnitView.__c__DisplayClass11_0.NativeMethodInfoPtr__HasPosition_b__0_Internal_Boolean_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView.__c__DisplayClass11_0>.NativeClassPtr, 100664318);
			}

			// Token: 0x06000CD7 RID: 3287 RVA: 0x00032E30 File Offset: 0x00031030
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitView.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CD8 RID: 3288 RVA: 0x00032E6C File Offset: 0x0003106C
			[CallerCount(0)]
			public unsafe bool _HasPosition_b__0(UnitPosition position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.__c__DisplayClass11_0.NativeMethodInfoPtr__HasPosition_b__0_Internal_Boolean_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CD9 RID: 3289 RVA: 0x00008547 File Offset: 0x00006747
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003CA RID: 970
			// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00032EBC File Offset: 0x000310BC
			// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00008550 File Offset: 0x00006750
			public unsafe UnitPosition unitPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.__c__DisplayClass11_0.NativeFieldInfoPtr_unitPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.__c__DisplayClass11_0.NativeFieldInfoPtr_unitPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040007FB RID: 2043
			private static readonly IntPtr NativeFieldInfoPtr_unitPosition;

			// Token: 0x040007FC RID: 2044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040007FD RID: 2045
			private static readonly IntPtr NativeMethodInfoPtr__HasPosition_b__0_Internal_Boolean_UnitPosition_0;
		}

		// Token: 0x020000FC RID: 252
		[ObfuscatedName("lotus.UnitView+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06000CDC RID: 3292 RVA: 0x00032EEC File Offset: 0x000310EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<UnitView.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitView>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitView.__c__DisplayClass9_0>.NativeClassPtr);
				UnitView.__c__DisplayClass9_0.NativeFieldInfoPtr_moveLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitView.__c__DisplayClass9_0>.NativeClassPtr, "moveLayer");
				UnitView.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView.__c__DisplayClass9_0>.NativeClassPtr, 100664319);
				UnitView.__c__DisplayClass9_0.NativeMethodInfoPtr__GetPosition_b__0_Internal_Boolean_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitView.__c__DisplayClass9_0>.NativeClassPtr, 100664320);
			}

			// Token: 0x06000CDD RID: 3293 RVA: 0x00032F54 File Offset: 0x00031154
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitView.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CDE RID: 3294 RVA: 0x00032F90 File Offset: 0x00031190
			[CallerCount(0)]
			public unsafe bool _GetPosition_b__0(UnitPosition position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitView.__c__DisplayClass9_0.NativeMethodInfoPtr__GetPosition_b__0_Internal_Boolean_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CDF RID: 3295 RVA: 0x0000856F File Offset: 0x0000676F
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003CB RID: 971
			// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00032FE0 File Offset: 0x000311E0
			// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00008578 File Offset: 0x00006778
			public unsafe int moveLayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.__c__DisplayClass9_0.NativeFieldInfoPtr_moveLayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitView.__c__DisplayClass9_0.NativeFieldInfoPtr_moveLayer)) = value;
				}
			}

			// Token: 0x040007FE RID: 2046
			private static readonly IntPtr NativeFieldInfoPtr_moveLayer;

			// Token: 0x040007FF RID: 2047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000800 RID: 2048
			private static readonly IntPtr NativeMethodInfoPtr__GetPosition_b__0_Internal_Boolean_UnitPosition_0;
		}
	}
}
