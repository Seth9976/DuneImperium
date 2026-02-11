using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lib.canis.voodoo.src.voodoo.renderAnimator
{
	// Token: 0x02000012 RID: 18
	public class GenericEventLocation : MonoBehaviour
	{
		// Token: 0x0600008B RID: 139 RVA: 0x0000AB74 File Offset: 0x00008D74
		// Note: this type is marked as 'beforefieldinit'.
		static GenericEventLocation()
		{
			Il2CppClassPointerStore<GenericEventLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.canis.voodoo.src.voodoo.renderAnimator", "GenericEventLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericEventLocation>.NativeClassPtr);
			GenericEventLocation.NativeFieldInfoPtr_eventTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEventLocation>.NativeClassPtr, "eventTriggers");
			GenericEventLocation.NativeFieldInfoPtr_locator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEventLocation>.NativeClassPtr, "locator");
			GenericEventLocation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventLocation>.NativeClassPtr, 100663361);
			GenericEventLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventLocation>.NativeClassPtr, 100663362);
			GenericEventLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventLocation>.NativeClassPtr, 100663363);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000AC08 File Offset: 0x00008E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106807, XrefRangeEnd = 1106817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventLocation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000AC3C File Offset: 0x00008E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106817, XrefRangeEnd = 1106825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000AC70 File Offset: 0x00008E70
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericEventLocation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericEventLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000259B File Offset: 0x0000079B
		public GenericEventLocation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000ACAC File Offset: 0x00008EAC
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000025A4 File Offset: 0x000007A4
		public unsafe Il2CppReferenceArray<EventTrigger> eventTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventLocation.NativeFieldInfoPtr_eventTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventTrigger>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventLocation.NativeFieldInfoPtr_eventTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000ACDC File Offset: 0x00008EDC
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000025C3 File Offset: 0x000007C3
		public unsafe GenericEventLocator locator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventLocation.NativeFieldInfoPtr_locator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericEventLocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventLocation.NativeFieldInfoPtr_locator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_eventTriggers;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_locator;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
