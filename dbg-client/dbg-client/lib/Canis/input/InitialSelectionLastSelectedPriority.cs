using System;
using boardgames.match.selection;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.src.util;
using lotus;

namespace lib.canis.input
{
	// Token: 0x0200002A RID: 42
	public class InitialSelectionLastSelectedPriority : InitialSelectionPriority
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00022ACC File Offset: 0x00020CCC
		// Note: this type is marked as 'beforefieldinit'.
		static InitialSelectionLastSelectedPriority()
		{
			Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.input", "InitialSelectionLastSelectedPriority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr);
			InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_lastSelectedPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, "lastSelectedPriority");
			InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, "view");
			InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_lastSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, "lastSelected");
			InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_dbgSelectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, "dbgSelectionResponder");
			InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, 100663578);
			InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, 100663579);
			InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, 100663580);
			InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_selectionSubmitted_Private_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, 100663581);
			InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, 100663582);
			InitialSelectionLastSelectedPriority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr, 100663583);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00022BC4 File Offset: 0x00020DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497671, XrefRangeEnd = 497675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00022BF8 File Offset: 0x00020DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497675, XrefRangeEnd = 497705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00022C2C File Offset: 0x00020E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497705, XrefRangeEnd = 497722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00022C60 File Offset: 0x00020E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497722, XrefRangeEnd = 497731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void selectionSubmitted(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_selectionSubmitted_Private_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00022CA4 File Offset: 0x00020EA4
		[CallerCount(0)]
		public unsafe override int getPriority()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitialSelectionLastSelectedPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00022CEC File Offset: 0x00020EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497731, XrefRangeEnd = 497732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitialSelectionLastSelectedPriority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitialSelectionLastSelectedPriority>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionLastSelectedPriority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002A30 File Offset: 0x00000C30
		public InitialSelectionLastSelectedPriority(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00022D28 File Offset: 0x00020F28
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002A39 File Offset: 0x00000C39
		public unsafe int lastSelectedPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_lastSelectedPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_lastSelectedPriority)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00022D50 File Offset: 0x00020F50
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002A54 File Offset: 0x00000C54
		public unsafe EntityView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00022D80 File Offset: 0x00020F80
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002A73 File Offset: 0x00000C73
		public unsafe bool lastSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_lastSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_lastSelected)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00022DA8 File Offset: 0x00020FA8
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002A8E File Offset: 0x00000C8E
		public unsafe DBGSelectionResponder dbgSelectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_dbgSelectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionLastSelectedPriority.NativeFieldInfoPtr_dbgSelectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedPriority;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_lastSelected;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_dbgSelectionResponder;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_selectionSubmitted_Private_Void_EntityID_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
