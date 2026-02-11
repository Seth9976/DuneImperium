using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace boardgames.match.selection
{
	// Token: 0x02000270 RID: 624
	public class SelectionRootHandler : Object
	{
		// Token: 0x06001D0A RID: 7434 RVA: 0x0007DCE4 File Offset: 0x0007BEE4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionRootHandler()
		{
			Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "SelectionRootHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr);
			SelectionRootHandler.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, "<Version>k__BackingField");
			SelectionRootHandler.NativeFieldInfoPtr_SelectionRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, "SelectionRoot");
			SelectionRootHandler.NativeFieldInfoPtr__CachedChoice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, "<CachedChoice>k__BackingField");
			SelectionRootHandler.NativeFieldInfoPtr_SelectionFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, "SelectionFilters");
			SelectionRootHandler.NativeFieldInfoPtr_SelectionCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, "SelectionCommand");
			SelectionRootHandler.NativeFieldInfoPtr_InterruptableCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, "InterruptableCommand");
			SelectionRootHandler.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668064);
			SelectionRootHandler.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668065);
			SelectionRootHandler.NativeMethodInfoPtr_get_CurrentChoice_Public_get_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668066);
			SelectionRootHandler.NativeMethodInfoPtr_get_CachedChoice_Public_get_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668067);
			SelectionRootHandler.NativeMethodInfoPtr_set_CachedChoice_Private_set_Void_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668068);
			SelectionRootHandler.NativeMethodInfoPtr__ctor_Public_Void_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668069);
			SelectionRootHandler.NativeMethodInfoPtr_UpdateCurrentChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668070);
			SelectionRootHandler.NativeMethodInfoPtr_FiltersActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668071);
			SelectionRootHandler.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668072);
			SelectionRootHandler.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668073);
			SelectionRootHandler.NativeMethodInfoPtr_ValidateSelection_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668074);
			SelectionRootHandler.NativeMethodInfoPtr_ValidateSelection_Public_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668075);
			SelectionRootHandler.NativeMethodInfoPtr_ValidateAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668076);
			SelectionRootHandler.NativeMethodInfoPtr_AttemptCancel_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668077);
			SelectionRootHandler.NativeMethodInfoPtr_MayAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668078);
			SelectionRootHandler.NativeMethodInfoPtr_ValidateCancel_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668079);
			SelectionRootHandler.NativeMethodInfoPtr_MayCancel_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668080);
			SelectionRootHandler.NativeMethodInfoPtr_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668081);
			SelectionRootHandler.NativeMethodInfoPtr_AttemptAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668082);
			SelectionRootHandler.NativeMethodInfoPtr_EntityIsSelectable_Public_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668083);
			SelectionRootHandler.NativeMethodInfoPtr_EntityIsPreviousSelection_Public_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668084);
			SelectionRootHandler.NativeMethodInfoPtr_PeekKind_Public_ISelectionNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668085);
			SelectionRootHandler.NativeMethodInfoPtr_EntityHasLeafSelection_Public_Boolean_EntityComponent_byref_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668086);
			SelectionRootHandler.NativeMethodInfoPtr_HasUndo_Public_Boolean_EntityID_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668087);
			SelectionRootHandler.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, 100668088);
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0007DF80 File Offset: 0x0007C180
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0007DFBC File Offset: 0x0007C1BC
		public unsafe virtual ulong Version
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0007DFFC File Offset: 0x0007C1FC
		public unsafe ISelectionNode CurrentChoice
		{
			[CallerCount(59)]
			[CachedScanResults(RefRangeStart = 536303, RefRangeEnd = 536362, XrefRangeStart = 536300, XrefRangeEnd = 536303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_get_CurrentChoice_Public_get_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x0007E03C File Offset: 0x0007C23C
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x0007E07C File Offset: 0x0007C27C
		public unsafe ISelectionNode CachedChoice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_get_CachedChoice_Public_get_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_set_CachedChoice_Private_set_Void_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0007E0C0 File Offset: 0x0007C2C0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionRootHandler(ISelectionRoot selectionRoot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr__ctor_Public_Void_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0007E10C File Offset: 0x0007C30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536362, XrefRangeEnd = 536367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentChoice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_UpdateCurrentChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0007E140 File Offset: 0x0007C340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536367, XrefRangeEnd = 536370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FiltersActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_FiltersActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0007E17C File Offset: 0x0007C37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536370, XrefRangeEnd = 536371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AttemptSubmitSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0007E1C8 File Offset: 0x0007C3C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536372, RefRangeEnd = 536373, XrefRangeStart = 536371, XrefRangeEnd = 536372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AttemptSubmitSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_AttemptSubmitSelection_Public_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x0007E218 File Offset: 0x0007C418
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 536380, RefRangeEnd = 536384, XrefRangeStart = 536373, XrefRangeEnd = 536380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_ValidateSelection_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0007E264 File Offset: 0x0007C464
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 536410, RefRangeEnd = 536418, XrefRangeStart = 536384, XrefRangeEnd = 536410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateSelection(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_ValidateSelection_Public_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0007E2B4 File Offset: 0x0007C4B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 536430, RefRangeEnd = 536433, XrefRangeStart = 536418, XrefRangeEnd = 536430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_ValidateAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0007E2F0 File Offset: 0x0007C4F0
		[CallerCount(0)]
		public unsafe bool AttemptCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_AttemptCancel_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0007E32C File Offset: 0x0007C52C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 536439, RefRangeEnd = 536444, XrefRangeStart = 536433, XrefRangeEnd = 536439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MayAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_MayAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0007E368 File Offset: 0x0007C568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536444, XrefRangeEnd = 536452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ValidateCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionRootHandler.NativeMethodInfoPtr_ValidateCancel_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0007E3B0 File Offset: 0x0007C5B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 536458, RefRangeEnd = 536462, XrefRangeStart = 536452, XrefRangeEnd = 536458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MayCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_MayCancel_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0007E3EC File Offset: 0x0007C5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536469, RefRangeEnd = 536470, XrefRangeStart = 536462, XrefRangeEnd = 536469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<T> GetOfferAttribute<T>(AttributeDefinition<T> attributeDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeDefinition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.MethodInfoStoreGeneric_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0007E43C File Offset: 0x0007C63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536470, XrefRangeEnd = 536475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AttemptAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_AttemptAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0007E478 File Offset: 0x0007C678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536475, XrefRangeEnd = 536476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EntityIsSelectable(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_EntityIsSelectable_Public_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0007E4C8 File Offset: 0x0007C6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536476, XrefRangeEnd = 536477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EntityIsPreviousSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_EntityIsPreviousSelection_Public_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x0007E518 File Offset: 0x0007C718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536477, XrefRangeEnd = 536494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISelectionNode PeekKind(string kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(kind);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_PeekKind_Public_ISelectionNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0007E568 File Offset: 0x0007C768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536494, XrefRangeEnd = 536506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EntityHasLeafSelection(EntityComponent entity, out ISelectionNode leafNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_EntityHasLeafSelection_Public_Boolean_EntityComponent_byref_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			leafNode = ((intPtr4 == 0) ? null : new ISelectionNode(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0007E5D8 File Offset: 0x0007C7D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 536570, RefRangeEnd = 536571, XrefRangeStart = 536506, XrefRangeEnd = 536570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasUndo(EntityID undoEntityID, out int selectionCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoEntityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &selectionCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.NativeMethodInfoPtr_HasUndo_Public_Boolean_EntityID_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0007E634 File Offset: 0x0007C834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536571, XrefRangeEnd = 536603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionRootHandler.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0000F789 File Offset: 0x0000D989
		public SelectionRootHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0007E678 File Offset: 0x0007C878
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000F792 File Offset: 0x0000D992
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0007E6A0 File Offset: 0x0007C8A0
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000F7AD File Offset: 0x0000D9AD
		public unsafe ISelectionRoot SelectionRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr_SelectionRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr_SelectionRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x0007E6D0 File Offset: 0x0007C8D0
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000F7CC File Offset: 0x0000D9CC
		public unsafe ISelectionNode _CachedChoice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr__CachedChoice_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr__CachedChoice_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0007E700 File Offset: 0x0007C900
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000F7EB File Offset: 0x0000D9EB
		public unsafe EntityComponent SelectionFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr_SelectionFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr_SelectionFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x0007E730 File Offset: 0x0007C930
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0000F80A File Offset: 0x0000DA0A
		public unsafe DBGSelectionCommand SelectionCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr_SelectionCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr_SelectionCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0007E760 File Offset: 0x0007C960
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000F829 File Offset: 0x0000DA29
		public unsafe InterruptableCommand InterruptableCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr_InterruptableCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterruptableCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.NativeFieldInfoPtr_InterruptableCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeFieldInfoPtr_SelectionRoot;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeFieldInfoPtr__CachedChoice_k__BackingField;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeFieldInfoPtr_SelectionFilters;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeFieldInfoPtr_SelectionCommand;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeFieldInfoPtr_InterruptableCommand;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentChoice_Public_get_ISelectionNode_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_get_CachedChoice_Public_get_ISelectionNode_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_set_CachedChoice_Private_set_Void_ISelectionNode_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionRoot_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentChoice_Public_Void_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_FiltersActive_Public_Boolean_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_AttemptSubmitSelection_Public_Boolean_Int32_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_AttemptSubmitSelection_Public_Boolean_EntityID_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSelection_Public_Boolean_Int32_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSelection_Public_Boolean_EntityID_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAdvance_Public_Boolean_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_AttemptCancel_Public_Boolean_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_MayAdvance_Public_Boolean_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCancel_Public_Virtual_New_Boolean_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_MayCancel_Public_Boolean_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_AttemptAdvance_Public_Boolean_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsSelectable_Public_Boolean_EntityID_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsPreviousSelection_Public_Boolean_EntityID_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_PeekKind_Public_ISelectionNode_String_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_EntityHasLeafSelection_Public_Boolean_EntityComponent_byref_ISelectionNode_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_HasUndo_Public_Boolean_EntityID_byref_Int32_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000467 RID: 1127
		[ObfuscatedName("boardgames.match.selection.SelectionRootHandler+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Object
		{
			// Token: 0x06003587 RID: 13703 RVA: 0x000C8614 File Offset: 0x000C6814
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<SelectionRootHandler.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionRootHandler.__c__DisplayClass30_0>.NativeClassPtr);
				SelectionRootHandler.__c__DisplayClass30_0.NativeFieldInfoPtr_kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionRootHandler.__c__DisplayClass30_0>.NativeClassPtr, "kind");
				SelectionRootHandler.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler.__c__DisplayClass30_0>.NativeClassPtr, 100668089);
				SelectionRootHandler.__c__DisplayClass30_0.NativeMethodInfoPtr__PeekKind_b__0_Internal_Boolean_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRootHandler.__c__DisplayClass30_0>.NativeClassPtr, 100668090);
			}

			// Token: 0x06003588 RID: 13704 RVA: 0x000C867C File Offset: 0x000C687C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionRootHandler.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003589 RID: 13705 RVA: 0x000C86B8 File Offset: 0x000C68B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536295, XrefRangeEnd = 536300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PeekKind_b__0(ISelectionNode child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRootHandler.__c__DisplayClass30_0.NativeMethodInfoPtr__PeekKind_b__0_Internal_Boolean_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600358A RID: 13706 RVA: 0x0001B9F7 File Offset: 0x00019BF7
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FBA RID: 4026
			// (get) Token: 0x0600358B RID: 13707 RVA: 0x000C8708 File Offset: 0x000C6908
			// (set) Token: 0x0600358C RID: 13708 RVA: 0x0001BA00 File Offset: 0x00019C00
			public unsafe string kind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.__c__DisplayClass30_0.NativeFieldInfoPtr_kind);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRootHandler.__c__DisplayClass30_0.NativeFieldInfoPtr_kind), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040020FC RID: 8444
			private static readonly IntPtr NativeFieldInfoPtr_kind;

			// Token: 0x040020FD RID: 8445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020FE RID: 8446
			private static readonly IntPtr NativeMethodInfoPtr__PeekKind_b__0_Internal_Boolean_ISelectionNode_0;
		}

		// Token: 0x02000468 RID: 1128
		private sealed class MethodInfoStoreGeneric_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x040020FF RID: 8447
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SelectionRootHandler.NativeMethodInfoPtr_GetOfferAttribute_Public_ReadOnlyAttribute_1_T_AttributeDefinition_1_T_0, Il2CppClassPointerStore<SelectionRootHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
