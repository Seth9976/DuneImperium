using System;
using boardgames.hints;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.components
{
	// Token: 0x02000222 RID: 546
	public class WormWillClearUndoHinter : DBGHinter
	{
		// Token: 0x060017ED RID: 6125 RVA: 0x00060A78 File Offset: 0x0005EC78
		// Note: this type is marked as 'beforefieldinit'.
		static WormWillClearUndoHinter()
		{
			Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormWillClearUndoHinter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr);
			WormWillClearUndoHinter.NativeFieldInfoPtr_hintFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, "hintFlavor");
			WormWillClearUndoHinter.NativeFieldInfoPtr__CursorHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, "<CursorHandler>k__BackingField");
			WormWillClearUndoHinter.NativeFieldInfoPtr_hinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, "hinting");
			WormWillClearUndoHinter.NativeMethodInfoPtr_get_CursorHandler_Protected_get_WormWillClearUndoCursorHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, 100666616);
			WormWillClearUndoHinter.NativeMethodInfoPtr_set_CursorHandler_Private_set_Void_WormWillClearUndoCursorHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, 100666617);
			WormWillClearUndoHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, 100666618);
			WormWillClearUndoHinter.NativeMethodInfoPtr_SetHint_Public_Virtual_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, 100666619);
			WormWillClearUndoHinter.NativeMethodInfoPtr_SetCursor_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, 100666620);
			WormWillClearUndoHinter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, 100666621);
			WormWillClearUndoHinter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr, 100666622);
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x00060B70 File Offset: 0x0005ED70
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x00060BB0 File Offset: 0x0005EDB0
		public unsafe WormWillClearUndoCursorHandler CursorHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoHinter.NativeMethodInfoPtr_get_CursorHandler_Protected_get_WormWillClearUndoCursorHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormWillClearUndoCursorHandler>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoHinter.NativeMethodInfoPtr_set_CursorHandler_Private_set_Void_WormWillClearUndoCursorHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00060BF4 File Offset: 0x0005EDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717865, XrefRangeEnd = 717870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00060C30 File Offset: 0x0005EE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717870, XrefRangeEnd = 717872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetHint(string flavor, bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoHinter.NativeMethodInfoPtr_SetHint_Public_Virtual_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00060C8C File Offset: 0x0005EE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717872, XrefRangeEnd = 717874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoHinter.NativeMethodInfoPtr_SetCursor_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00060CC8 File Offset: 0x0005EEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717874, XrefRangeEnd = 717875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoHinter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00060CFC File Offset: 0x0005EEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWillClearUndoHinter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWillClearUndoHinter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoHinter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0000E412 File Offset: 0x0000C612
		public WormWillClearUndoHinter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00060D38 File Offset: 0x0005EF38
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0000E41B File Offset: 0x0000C61B
		public unsafe string hintFlavor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoHinter.NativeFieldInfoPtr_hintFlavor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoHinter.NativeFieldInfoPtr_hintFlavor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00060D60 File Offset: 0x0005EF60
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0000E43A File Offset: 0x0000C63A
		public unsafe WormWillClearUndoCursorHandler _CursorHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoHinter.NativeFieldInfoPtr__CursorHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormWillClearUndoCursorHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoHinter.NativeFieldInfoPtr__CursorHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00060D90 File Offset: 0x0005EF90
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x0000E459 File Offset: 0x0000C659
		public unsafe bool hinting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoHinter.NativeFieldInfoPtr_hinting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoHinter.NativeFieldInfoPtr_hinting)) = value;
			}
		}

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeFieldInfoPtr_hintFlavor;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeFieldInfoPtr__CursorHandler_k__BackingField;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeFieldInfoPtr_hinting;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_get_CursorHandler_Protected_get_WormWillClearUndoCursorHandler_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_set_CursorHandler_Private_set_Void_WormWillClearUndoCursorHandler_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_SetHint_Public_Virtual_Void_String_Boolean_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_SetCursor_Protected_Virtual_New_Void_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
