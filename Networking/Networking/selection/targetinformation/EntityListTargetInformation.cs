using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetinformation
{
	// Token: 0x0200006A RID: 106
	public class EntityListTargetInformation : TargetInformation
	{
		// Token: 0x06000378 RID: 888 RVA: 0x0000ED74 File Offset: 0x0000CF74
		// Note: this type is marked as 'beforefieldinit'.
		static EntityListTargetInformation()
		{
			Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "EntityListTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr);
			EntityListTargetInformation.NativeFieldInfoPtr_ValidTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr, "ValidTargets");
			EntityListTargetInformation.NativeFieldInfoPtr_NumberToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr, "NumberToSelect");
			EntityListTargetInformation.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr, "Forced");
			EntityListTargetInformation.NativeFieldInfoPtr_MinimumToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr, "MinimumToSelect");
			EntityListTargetInformation.NativeFieldInfoPtr_HintTargetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr, "HintTargetMap");
			EntityListTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr, 100663488);
			EntityListTargetInformation.NativeMethodInfoPtr_Clone_Public_EntityListTargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr, 100663489);
			EntityListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr, 100663490);
			EntityListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr, 100663491);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000EE58 File Offset: 0x0000D058
		public unsafe override bool ForcedSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityListTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194210, XrefRangeEnd = 1194213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetInformation Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetInformation.NativeMethodInfoPtr_Clone_Public_EntityListTargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityListTargetInformation>(intPtr3) : null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194213, XrefRangeEnd = 1194219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000EF24 File Offset: 0x0000D124
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityListTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000043D0 File Offset: 0x000025D0
		public EntityListTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000EF60 File Offset: 0x0000D160
		// (set) Token: 0x0600037F RID: 895 RVA: 0x000043D9 File Offset: 0x000025D9
		public unsafe Il2CppReferenceArray<EntityID> ValidTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_ValidTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_ValidTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000EF90 File Offset: 0x0000D190
		// (set) Token: 0x06000381 RID: 897 RVA: 0x000043F8 File Offset: 0x000025F8
		public unsafe int NumberToSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_NumberToSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_NumberToSelect)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00004413 File Offset: 0x00002613
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000EFE0 File Offset: 0x0000D1E0
		// (set) Token: 0x06000385 RID: 901 RVA: 0x0000442E File Offset: 0x0000262E
		public unsafe int MinimumToSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_MinimumToSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_MinimumToSelect)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000F008 File Offset: 0x0000D208
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00004449 File Offset: 0x00002649
		public unsafe Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>> HintTargetMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_HintTargetMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityListTargetInformation.NativeFieldInfoPtr_HintTargetMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_ValidTargets;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_NumberToSelect;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_MinimumToSelect;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_HintTargetMap;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_EntityListTargetInformation_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
