using System;
using boardgames.match.behaviours;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.src.util;
using lotus;

namespace lib.canis.input
{
	// Token: 0x02000027 RID: 39
	public class InitialSelectionFilteredPriority : InitialSelectionPriority
	{
		// Token: 0x06000170 RID: 368 RVA: 0x0002240C File Offset: 0x0002060C
		// Note: this type is marked as 'beforefieldinit'.
		static InitialSelectionFilteredPriority()
		{
			Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.input", "InitialSelectionFilteredPriority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr);
			InitialSelectionFilteredPriority.NativeFieldInfoPtr_inFilterPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr, "inFilterPriority");
			InitialSelectionFilteredPriority.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr, "entitiesProvider");
			InitialSelectionFilteredPriority.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr, "selection");
			InitialSelectionFilteredPriority.NativeFieldInfoPtr_entityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr, "entityView");
			InitialSelectionFilteredPriority.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr, 100663559);
			InitialSelectionFilteredPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr, 100663560);
			InitialSelectionFilteredPriority.NativeMethodInfoPtr_includedInFakeTutorialSelection_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr, 100663561);
			InitialSelectionFilteredPriority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr, 100663562);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000224DC File Offset: 0x000206DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497516, XrefRangeEnd = 497534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionFilteredPriority.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00022510 File Offset: 0x00020710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497534, XrefRangeEnd = 497568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int getPriority()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitialSelectionFilteredPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00022558 File Offset: 0x00020758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497603, RefRangeEnd = 497604, XrefRangeStart = 497568, XrefRangeEnd = 497603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool includedInFakeTutorialSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionFilteredPriority.NativeMethodInfoPtr_includedInFakeTutorialSelection_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00022594 File Offset: 0x00020794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497604, XrefRangeEnd = 497605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitialSelectionFilteredPriority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitialSelectionFilteredPriority>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionFilteredPriority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002929 File Offset: 0x00000B29
		public InitialSelectionFilteredPriority(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000225D0 File Offset: 0x000207D0
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002932 File Offset: 0x00000B32
		public unsafe int inFilterPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionFilteredPriority.NativeFieldInfoPtr_inFilterPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionFilteredPriority.NativeFieldInfoPtr_inFilterPriority)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000225F8 File Offset: 0x000207F8
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000294D File Offset: 0x00000B4D
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionFilteredPriority.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionFilteredPriority.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00022628 File Offset: 0x00020828
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000296C File Offset: 0x00000B6C
		public unsafe DBGSelectionResponder selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionFilteredPriority.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionFilteredPriority.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00022658 File Offset: 0x00020858
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000298B File Offset: 0x00000B8B
		public unsafe EntityView entityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionFilteredPriority.NativeFieldInfoPtr_entityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionFilteredPriority.NativeFieldInfoPtr_entityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_inFilterPriority;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_entityView;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_includedInFakeTutorialSelection_Private_Boolean_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
