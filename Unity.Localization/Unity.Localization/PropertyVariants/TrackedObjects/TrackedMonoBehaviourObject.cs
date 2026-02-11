using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	// Token: 0x020000FA RID: 250
	[Serializable]
	public class TrackedMonoBehaviourObject : JsonSerializerTrackedObject
	{
		// Token: 0x06000C0C RID: 3084 RVA: 0x00036A14 File Offset: 0x00034C14
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedMonoBehaviourObject()
		{
			Il2CppClassPointerStore<TrackedMonoBehaviourObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedObjects", "TrackedMonoBehaviourObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedMonoBehaviourObject>.NativeClassPtr);
			TrackedMonoBehaviourObject.NativeFieldInfoPtr_m_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedMonoBehaviourObject>.NativeClassPtr, "m_Changed");
			TrackedMonoBehaviourObject.NativeMethodInfoPtr_get_Changed_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMonoBehaviourObject>.NativeClassPtr, 100665295);
			TrackedMonoBehaviourObject.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMonoBehaviourObject>.NativeClassPtr, 100665296);
			TrackedMonoBehaviourObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMonoBehaviourObject>.NativeClassPtr, 100665297);
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00036A94 File Offset: 0x00034C94
		public unsafe UnityEvent Changed
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMonoBehaviourObject.NativeMethodInfoPtr_get_Changed_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00036AD4 File Offset: 0x00034CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080508, XrefRangeEnd = 1080510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostApplyTrackedProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedMonoBehaviourObject.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00036B10 File Offset: 0x00034D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080510, XrefRangeEnd = 1080516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedMonoBehaviourObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedMonoBehaviourObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMonoBehaviourObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000071BB File Offset: 0x000053BB
		public TrackedMonoBehaviourObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00036B4C File Offset: 0x00034D4C
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x000071C4 File Offset: 0x000053C4
		public unsafe UnityEvent m_Changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMonoBehaviourObject.NativeFieldInfoPtr_m_Changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMonoBehaviourObject.NativeFieldInfoPtr_m_Changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeFieldInfoPtr_m_Changed;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_get_Changed_Public_get_UnityEvent_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_Void_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
