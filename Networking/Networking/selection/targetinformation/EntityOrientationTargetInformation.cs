using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetinformation
{
	// Token: 0x0200006B RID: 107
	public class EntityOrientationTargetInformation : TargetInformation
	{
		// Token: 0x06000388 RID: 904 RVA: 0x0000F038 File Offset: 0x0000D238
		// Note: this type is marked as 'beforefieldinit'.
		static EntityOrientationTargetInformation()
		{
			Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "EntityOrientationTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr);
			EntityOrientationTargetInformation.NativeFieldInfoPtr_SpacesAndOrientations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr, "SpacesAndOrientations");
			EntityOrientationTargetInformation.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr, "Forced");
			EntityOrientationTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr, 100663492);
			EntityOrientationTargetInformation.NativeMethodInfoPtr_get_HasValidTarget_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr, 100663493);
			EntityOrientationTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr, 100663494);
			EntityOrientationTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr, 100663495);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
		public unsafe override bool ForcedSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityOrientationTargetInformation.NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000F128 File Offset: 0x0000D328
		public unsafe virtual bool HasValidTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194220, XrefRangeEnd = 1194238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOrientationTargetInformation.NativeMethodInfoPtr_get_HasValidTarget_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000F164 File Offset: 0x0000D364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194238, XrefRangeEnd = 1194249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityOrientationTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000F1A8 File Offset: 0x0000D3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194249, XrefRangeEnd = 1194257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityOrientationTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOrientationTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00004468 File Offset: 0x00002668
		public EntityOrientationTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000F1E4 File Offset: 0x0000D3E4
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00004471 File Offset: 0x00002671
		public unsafe Dictionary<EntityID, Il2CppStructArray<int>> SpacesAndOrientations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetInformation.NativeFieldInfoPtr_SpacesAndOrientations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetInformation.NativeFieldInfoPtr_SpacesAndOrientations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000F214 File Offset: 0x0000D414
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00004490 File Offset: 0x00002690
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetInformation.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityOrientationTargetInformation.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_SpacesAndOrientations;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelection_Public_Virtual_get_Boolean_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValidTarget_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C6 RID: 198
		[ObfuscatedName("Networking.selection.targetinformation.EntityOrientationTargetInformation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600066E RID: 1646 RVA: 0x00016C84 File Offset: 0x00014E84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EntityOrientationTargetInformation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityOrientationTargetInformation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOrientationTargetInformation.__c>.NativeClassPtr);
				EntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOrientationTargetInformation.__c>.NativeClassPtr, "<>9");
				EntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOrientationTargetInformation.__c>.NativeClassPtr, "<>9__5_0");
				EntityOrientationTargetInformation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetInformation.__c>.NativeClassPtr, 100663497);
				EntityOrientationTargetInformation.__c.NativeMethodInfoPtr__get_HasValidTarget_b__5_0_Internal_Boolean_KeyValuePair_2_EntityID_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOrientationTargetInformation.__c>.NativeClassPtr, 100663498);
			}

			// Token: 0x0600066F RID: 1647 RVA: 0x00016D00 File Offset: 0x00014F00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityOrientationTargetInformation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOrientationTargetInformation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x00016D3C File Offset: 0x00014F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194219, XrefRangeEnd = 1194220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_HasValidTarget_b__5_0(KeyValuePair<EntityID, Il2CppStructArray<int>> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityOrientationTargetInformation.__c.NativeMethodInfoPtr__get_HasValidTarget_b__5_0_Internal_Boolean_KeyValuePair_2_EntityID_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x00006025 File Offset: 0x00004225
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x06000672 RID: 1650 RVA: 0x00016D90 File Offset: 0x00014F90
			// (set) Token: 0x06000673 RID: 1651 RVA: 0x0000602E File Offset: 0x0000422E
			public unsafe static EntityOrientationTargetInformation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityOrientationTargetInformation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x06000674 RID: 1652 RVA: 0x00016DB8 File Offset: 0x00014FB8
			// (set) Token: 0x06000675 RID: 1653 RVA: 0x00006040 File Offset: 0x00004240
			public unsafe static Func<KeyValuePair<EntityID, Il2CppStructArray<int>>, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, Il2CppStructArray<int>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityOrientationTargetInformation.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000357 RID: 855
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000358 RID: 856
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04000359 RID: 857
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400035A RID: 858
			private static readonly IntPtr NativeMethodInfoPtr__get_HasValidTarget_b__5_0_Internal_Boolean_KeyValuePair_2_EntityID_Il2CppStructArray_1_Int32_0;
		}
	}
}
