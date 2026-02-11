using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.src.util;
using UnityEngine;

namespace lib.canis.input
{
	// Token: 0x02000026 RID: 38
	public class InitialSelectionChildIndexPriority : InitialSelectionPriority
	{
		// Token: 0x06000164 RID: 356 RVA: 0x000221DC File Offset: 0x000203DC
		// Note: this type is marked as 'beforefieldinit'.
		static InitialSelectionChildIndexPriority()
		{
			Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.input", "InitialSelectionChildIndexPriority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr);
			InitialSelectionChildIndexPriority.NativeFieldInfoPtr_rootTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr, "rootTransform");
			InitialSelectionChildIndexPriority.NativeFieldInfoPtr_Descending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr, "Descending");
			InitialSelectionChildIndexPriority.NativeFieldInfoPtr_cachedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr, "cachedTransform");
			InitialSelectionChildIndexPriority.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr, 100663555);
			InitialSelectionChildIndexPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr, 100663556);
			InitialSelectionChildIndexPriority.NativeMethodInfoPtr_CacheTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr, 100663557);
			InitialSelectionChildIndexPriority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr, 100663558);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00022298 File Offset: 0x00020498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497499, XrefRangeEnd = 497500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionChildIndexPriority.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000222CC File Offset: 0x000204CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497500, XrefRangeEnd = 497504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int getPriority()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitialSelectionChildIndexPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00022314 File Offset: 0x00020514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 497514, RefRangeEnd = 497516, XrefRangeStart = 497504, XrefRangeEnd = 497514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionChildIndexPriority.NativeMethodInfoPtr_CacheTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00022348 File Offset: 0x00020548
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitialSelectionChildIndexPriority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitialSelectionChildIndexPriority>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionChildIndexPriority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000028C7 File Offset: 0x00000AC7
		public InitialSelectionChildIndexPriority(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00022384 File Offset: 0x00020584
		// (set) Token: 0x0600016B RID: 363 RVA: 0x000028D0 File Offset: 0x00000AD0
		public unsafe Transform rootTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildIndexPriority.NativeFieldInfoPtr_rootTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildIndexPriority.NativeFieldInfoPtr_rootTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000223B4 File Offset: 0x000205B4
		// (set) Token: 0x0600016D RID: 365 RVA: 0x000028EF File Offset: 0x00000AEF
		public unsafe bool Descending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildIndexPriority.NativeFieldInfoPtr_Descending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildIndexPriority.NativeFieldInfoPtr_Descending)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000223DC File Offset: 0x000205DC
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000290A File Offset: 0x00000B0A
		public unsafe Transform cachedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildIndexPriority.NativeFieldInfoPtr_cachedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildIndexPriority.NativeFieldInfoPtr_cachedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_rootTransform;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_Descending;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_cachedTransform;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_CacheTransform_Private_Void_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
