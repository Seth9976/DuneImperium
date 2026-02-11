using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace voodoo
{
	// Token: 0x0200001A RID: 26
	public class UnitViewOverrideProvider : UnitViewProvider
	{
		// Token: 0x060000BF RID: 191 RVA: 0x0000B5F4 File Offset: 0x000097F4
		// Note: this type is marked as 'beforefieldinit'.
		static UnitViewOverrideProvider()
		{
			Il2CppClassPointerStore<UnitViewOverrideProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo", "UnitViewOverrideProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitViewOverrideProvider>.NativeClassPtr);
			UnitViewOverrideProvider.NativeFieldInfoPtr_viewPrefabOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitViewOverrideProvider>.NativeClassPtr, "viewPrefabOverride");
			UnitViewOverrideProvider.NativeFieldInfoPtr_viewLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitViewOverrideProvider>.NativeClassPtr, "viewLayer");
			UnitViewOverrideProvider.NativeFieldInfoPtr_viewPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitViewOverrideProvider>.NativeClassPtr, "viewPrefab");
			UnitViewOverrideProvider.NativeMethodInfoPtr_Init_Public_Virtual_Void_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitViewOverrideProvider>.NativeClassPtr, 100663388);
			UnitViewOverrideProvider.NativeMethodInfoPtr_GetUnitView_Public_Virtual_UnitView_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitViewOverrideProvider>.NativeClassPtr, 100663389);
			UnitViewOverrideProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitViewOverrideProvider>.NativeClassPtr, 100663390);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000B69C File Offset: 0x0000989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106912, XrefRangeEnd = 1106937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(ContainerView c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitViewOverrideProvider.NativeMethodInfoPtr_Init_Public_Virtual_Void_ContainerView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000B6EC File Offset: 0x000098EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106937, XrefRangeEnd = 1106940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UnitView GetUnitView(EntityComponent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitViewOverrideProvider.NativeMethodInfoPtr_GetUnitView_Public_Virtual_UnitView_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000B748 File Offset: 0x00009948
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitViewOverrideProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitViewOverrideProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitViewOverrideProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000270A File Offset: 0x0000090A
		public UnitViewOverrideProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000B784 File Offset: 0x00009984
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002713 File Offset: 0x00000913
		public unsafe UnitView viewPrefabOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewOverrideProvider.NativeFieldInfoPtr_viewPrefabOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewOverrideProvider.NativeFieldInfoPtr_viewPrefabOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000B7B4 File Offset: 0x000099B4
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002732 File Offset: 0x00000932
		public unsafe int viewLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewOverrideProvider.NativeFieldInfoPtr_viewLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewOverrideProvider.NativeFieldInfoPtr_viewLayer)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000B7DC File Offset: 0x000099DC
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000274D File Offset: 0x0000094D
		public unsafe UnitView viewPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewOverrideProvider.NativeFieldInfoPtr_viewPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewOverrideProvider.NativeFieldInfoPtr_viewPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_viewPrefabOverride;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_viewLayer;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_viewPrefab;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_ContainerView_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitView_Public_Virtual_UnitView_EntityComponent_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
