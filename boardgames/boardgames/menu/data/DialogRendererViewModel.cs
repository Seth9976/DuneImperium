using System;
using boardgames.voodoo.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menu.data
{
	// Token: 0x02000118 RID: 280
	public class DialogRendererViewModel : ManagedDataComponent
	{
		// Token: 0x06000EA5 RID: 3749 RVA: 0x0003D7EC File Offset: 0x0003B9EC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogRendererViewModel()
		{
			Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.menu.data", "DialogRendererViewModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr);
			DialogRendererViewModel.NativeFieldInfoPtr_isShowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr, "isShowing");
			DialogRendererViewModel.NativeFieldInfoPtr_isCollapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr, "isCollapsed");
			DialogRendererViewModel.NativeMethodInfoPtr_get_IsShowing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr, 100665385);
			DialogRendererViewModel.NativeMethodInfoPtr_set_IsShowing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr, 100665386);
			DialogRendererViewModel.NativeMethodInfoPtr_get_IsCollapsed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr, 100665387);
			DialogRendererViewModel.NativeMethodInfoPtr_set_IsCollapsed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr, 100665388);
			DialogRendererViewModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr, 100665389);
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0003D8A8 File Offset: 0x0003BAA8
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x0003D8E4 File Offset: 0x0003BAE4
		public unsafe bool IsShowing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererViewModel.NativeMethodInfoPtr_get_IsShowing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996713, XrefRangeEnd = 996714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererViewModel.NativeMethodInfoPtr_set_IsShowing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0003D924 File Offset: 0x0003BB24
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x0003D960 File Offset: 0x0003BB60
		public unsafe bool IsCollapsed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererViewModel.NativeMethodInfoPtr_get_IsCollapsed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996714, XrefRangeEnd = 996715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererViewModel.NativeMethodInfoPtr_set_IsCollapsed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0003D9A0 File Offset: 0x0003BBA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 996716, RefRangeEnd = 996717, XrefRangeStart = 996715, XrefRangeEnd = 996716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogRendererViewModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRendererViewModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRendererViewModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00008DD1 File Offset: 0x00006FD1
		public DialogRendererViewModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0003D9DC File Offset: 0x0003BBDC
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x00008DDA File Offset: 0x00006FDA
		public unsafe bool isShowing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererViewModel.NativeFieldInfoPtr_isShowing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererViewModel.NativeFieldInfoPtr_isShowing)) = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0003DA04 File Offset: 0x0003BC04
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x00008DF5 File Offset: 0x00006FF5
		public unsafe bool isCollapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererViewModel.NativeFieldInfoPtr_isCollapsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRendererViewModel.NativeFieldInfoPtr_isCollapsed)) = value;
			}
		}

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_isShowing;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_isCollapsed;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_get_IsShowing_Public_get_Boolean_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_set_IsShowing_Public_set_Void_Boolean_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCollapsed_Public_get_Boolean_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCollapsed_Public_set_Void_Boolean_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
