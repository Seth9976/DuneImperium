using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lib.src.match.voodoo.kabbage
{
	// Token: 0x0200000D RID: 13
	public class GenericFXLocation : MonoBehaviour
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0000A254 File Offset: 0x00008454
		// Note: this type is marked as 'beforefieldinit'.
		static GenericFXLocation()
		{
			Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.src.match.voodoo.kabbage", "GenericFXLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr);
			GenericFXLocation.NativeFieldInfoPtr_fxAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr, "fxAnimators");
			GenericFXLocation.NativeFieldInfoPtr_kabbageAnchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr, "kabbageAnchors");
			GenericFXLocation.NativeFieldInfoPtr_blockingAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr, "blockingAnimations");
			GenericFXLocation.NativeFieldInfoPtr_locator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr, "locator");
			GenericFXLocation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr, 100663339);
			GenericFXLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr, 100663340);
			GenericFXLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr, 100663341);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000A310 File Offset: 0x00008510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106667, XrefRangeEnd = 1106683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000A344 File Offset: 0x00008544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106683, XrefRangeEnd = 1106699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000A378 File Offset: 0x00008578
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericFXLocation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericFXLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000023ED File Offset: 0x000005ED
		public GenericFXLocation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000A3B4 File Offset: 0x000085B4
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000023F6 File Offset: 0x000005F6
		public unsafe Il2CppReferenceArray<FXAnimatorInfo> fxAnimators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocation.NativeFieldInfoPtr_fxAnimators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FXAnimatorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocation.NativeFieldInfoPtr_fxAnimators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000A3E4 File Offset: 0x000085E4
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002415 File Offset: 0x00000615
		public unsafe Il2CppReferenceArray<KabbageAnchorInfo> kabbageAnchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocation.NativeFieldInfoPtr_kabbageAnchors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KabbageAnchorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocation.NativeFieldInfoPtr_kabbageAnchors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000A414 File Offset: 0x00008614
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002434 File Offset: 0x00000634
		public unsafe Il2CppReferenceArray<BlockingFXInfo> blockingAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocation.NativeFieldInfoPtr_blockingAnimations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BlockingFXInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocation.NativeFieldInfoPtr_blockingAnimations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000A444 File Offset: 0x00008644
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002453 File Offset: 0x00000653
		public unsafe GenericFXLocator locator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocation.NativeFieldInfoPtr_locator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericFXLocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocation.NativeFieldInfoPtr_locator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_fxAnimators;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_kabbageAnchors;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_blockingAnimations;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_locator;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
