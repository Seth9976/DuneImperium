using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace voodoo.pathing
{
	// Token: 0x02000030 RID: 48
	public class DistributeOnPath : MonoBehaviour
	{
		// Token: 0x060001EB RID: 491 RVA: 0x0000F0AC File Offset: 0x0000D2AC
		// Note: this type is marked as 'beforefieldinit'.
		static DistributeOnPath()
		{
			Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing", "DistributeOnPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr);
			DistributeOnPath.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr, "target");
			DistributeOnPath.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr, "count");
			DistributeOnPath.NativeFieldInfoPtr_startingFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr, "startingFrom");
			DistributeOnPath.NativeFieldInfoPtr_endTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr, "endTo");
			DistributeOnPath.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr, "path");
			DistributeOnPath.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr, 100663506);
			DistributeOnPath.NativeMethodInfoPtr_Generate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr, 100663507);
			DistributeOnPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr, 100663508);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000F17C File Offset: 0x0000D37C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributeOnPath.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107751, XrefRangeEnd = 1107813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributeOnPath.NativeMethodInfoPtr_Generate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000F1E4 File Offset: 0x0000D3E4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DistributeOnPath()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributeOnPath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributeOnPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000030E2 File Offset: 0x000012E2
		public DistributeOnPath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000F220 File Offset: 0x0000D420
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x000030EB File Offset: 0x000012EB
		public unsafe GameObject target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000F250 File Offset: 0x0000D450
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000310A File Offset: 0x0000130A
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000F278 File Offset: 0x0000D478
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00003125 File Offset: 0x00001325
		public unsafe float startingFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_startingFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_startingFrom)) = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00003140 File Offset: 0x00001340
		public unsafe float endTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_endTo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_endTo)) = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000315B File Offset: 0x0000135B
		public unsafe PathVoodoo path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathVoodoo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributeOnPath.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_startingFrom;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_endTo;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Void_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
