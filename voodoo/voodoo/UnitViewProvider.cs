using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace voodoo
{
	// Token: 0x0200001B RID: 27
	public class UnitViewProvider : MonoBehaviour
	{
		// Token: 0x060000CA RID: 202 RVA: 0x0000B80C File Offset: 0x00009A0C
		// Note: this type is marked as 'beforefieldinit'.
		static UnitViewProvider()
		{
			Il2CppClassPointerStore<UnitViewProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo", "UnitViewProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitViewProvider>.NativeClassPtr);
			UnitViewProvider.NativeFieldInfoPtr_vm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitViewProvider>.NativeClassPtr, "vm");
			UnitViewProvider.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitViewProvider>.NativeClassPtr, "container");
			UnitViewProvider.NativeFieldInfoPtr_pm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitViewProvider>.NativeClassPtr, "pm");
			UnitViewProvider.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitViewProvider>.NativeClassPtr, 100663391);
			UnitViewProvider.NativeMethodInfoPtr_GetUnitView_Public_Virtual_New_UnitView_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitViewProvider>.NativeClassPtr, 100663392);
			UnitViewProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitViewProvider>.NativeClassPtr, 100663393);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000B8B4 File Offset: 0x00009AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1106959, RefRangeEnd = 1106960, XrefRangeStart = 1106940, XrefRangeEnd = 1106959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(ContainerView c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitViewProvider.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_ContainerView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000B904 File Offset: 0x00009B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106960, XrefRangeEnd = 1106967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual UnitView GetUnitView(EntityComponent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitViewProvider.NativeMethodInfoPtr_GetUnitView_Public_Virtual_New_UnitView_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr3) : null;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000B960 File Offset: 0x00009B60
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitViewProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitViewProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitViewProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000276C File Offset: 0x0000096C
		public UnitViewProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000B99C File Offset: 0x00009B9C
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002775 File Offset: 0x00000975
		public unsafe ViewManager vm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewProvider.NativeFieldInfoPtr_vm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewProvider.NativeFieldInfoPtr_vm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000B9CC File Offset: 0x00009BCC
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002794 File Offset: 0x00000994
		public unsafe ContainerView container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewProvider.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewProvider.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000B9FC File Offset: 0x00009BFC
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000027B3 File Offset: 0x000009B3
		public unsafe PoolManager pm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewProvider.NativeFieldInfoPtr_pm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitViewProvider.NativeFieldInfoPtr_pm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_vm;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_pm;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_ContainerView_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitView_Public_Virtual_New_UnitView_EntityComponent_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
