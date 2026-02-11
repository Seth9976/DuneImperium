using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000076 RID: 118
	public class RevealEntityListTargetInformation : EntityListTargetInformation
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x000103F8 File Offset: 0x0000E5F8
		// Note: this type is marked as 'beforefieldinit'.
		static RevealEntityListTargetInformation()
		{
			Il2CppClassPointerStore<RevealEntityListTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "RevealEntityListTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealEntityListTargetInformation>.NativeClassPtr);
			RevealEntityListTargetInformation.NativeFieldInfoPtr_AllTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealEntityListTargetInformation>.NativeClassPtr, "AllTargets");
			RevealEntityListTargetInformation.NativeFieldInfoPtr_UndoTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealEntityListTargetInformation>.NativeClassPtr, "UndoTarget");
			RevealEntityListTargetInformation.NativeFieldInfoPtr_RevealEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealEntityListTargetInformation>.NativeClassPtr, "RevealEntities");
			RevealEntityListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealEntityListTargetInformation>.NativeClassPtr, 100663540);
			RevealEntityListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealEntityListTargetInformation>.NativeClassPtr, 100663541);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001048C File Offset: 0x0000E68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194415, XrefRangeEnd = 1194428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RevealEntityListTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000104D0 File Offset: 0x0000E6D0
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 487155, RefRangeEnd = 487190, XrefRangeStart = 487155, XrefRangeEnd = 487190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealEntityListTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealEntityListTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealEntityListTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000471F File Offset: 0x0000291F
		public RevealEntityListTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0001050C File Offset: 0x0000E70C
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00004728 File Offset: 0x00002928
		public unsafe Il2CppReferenceArray<EntityID> AllTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealEntityListTargetInformation.NativeFieldInfoPtr_AllTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealEntityListTargetInformation.NativeFieldInfoPtr_AllTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0001053C File Offset: 0x0000E73C
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00004747 File Offset: 0x00002947
		public unsafe EntityID UndoTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealEntityListTargetInformation.NativeFieldInfoPtr_UndoTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealEntityListTargetInformation.NativeFieldInfoPtr_UndoTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0001056C File Offset: 0x0000E76C
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00004766 File Offset: 0x00002966
		public unsafe Dictionary<EntityID, ReadOnlyAttributes> RevealEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealEntityListTargetInformation.NativeFieldInfoPtr_RevealEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, ReadOnlyAttributes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealEntityListTargetInformation.NativeFieldInfoPtr_RevealEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_AllTargets;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_UndoTarget;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_RevealEntities;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
