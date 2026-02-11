using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.direBytes.data
{
	// Token: 0x02000023 RID: 35
	public class DireByteTileRelatedProductData : DataComponent
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x00008180 File Offset: 0x00006380
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTileRelatedProductData()
		{
			Il2CppClassPointerStore<DireByteTileRelatedProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "DireByteTileRelatedProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTileRelatedProductData>.NativeClassPtr);
			DireByteTileRelatedProductData.NativeFieldInfoPtr_RelatedIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileRelatedProductData>.NativeClassPtr, "RelatedIDs");
			DireByteTileRelatedProductData.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileRelatedProductData>.NativeClassPtr, 100663457);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000081D8 File Offset: 0x000063D8
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTileRelatedProductData(HashSet<ArchetypeID> relatedIDs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTileRelatedProductData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relatedIDs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileRelatedProductData.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002EB6 File Offset: 0x000010B6
		public DireByteTileRelatedProductData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00008224 File Offset: 0x00006424
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002EBF File Offset: 0x000010BF
		public unsafe HashSet<ArchetypeID> RelatedIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileRelatedProductData.NativeFieldInfoPtr_RelatedIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileRelatedProductData.NativeFieldInfoPtr_RelatedIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_RelatedIDs;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_ArchetypeID_0;
	}
}
