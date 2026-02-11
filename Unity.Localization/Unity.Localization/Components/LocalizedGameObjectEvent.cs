using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Localization.Events;

namespace UnityEngine.Localization.Components
{
	// Token: 0x020000C8 RID: 200
	public class LocalizedGameObjectEvent : LocalizedAssetEvent<GameObject, LocalizedGameObject, UnityEventGameObject>
	{
		// Token: 0x06000A8E RID: 2702 RVA: 0x00031264 File Offset: 0x0002F464
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedGameObjectEvent()
		{
			Il2CppClassPointerStore<LocalizedGameObjectEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Components", "LocalizedGameObjectEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedGameObjectEvent>.NativeClassPtr);
			LocalizedGameObjectEvent.NativeFieldInfoPtr_m_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedGameObjectEvent>.NativeClassPtr, "m_Current");
			LocalizedGameObjectEvent.NativeMethodInfoPtr_UpdateAsset_Protected_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedGameObjectEvent>.NativeClassPtr, 100665064);
			LocalizedGameObjectEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedGameObjectEvent>.NativeClassPtr, 100665065);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000312D0 File Offset: 0x0002F4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078790, XrefRangeEnd = 1078814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateAsset(GameObject localizedAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localizedAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedGameObjectEvent.NativeMethodInfoPtr_UpdateAsset_Protected_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00031320 File Offset: 0x0002F520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078814, XrefRangeEnd = 1078817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedGameObjectEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedGameObjectEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedGameObjectEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00006647 File Offset: 0x00004847
		public LocalizedGameObjectEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0003135C File Offset: 0x0002F55C
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00006650 File Offset: 0x00004850
		public unsafe GameObject m_Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedGameObjectEvent.NativeFieldInfoPtr_m_Current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedGameObjectEvent.NativeFieldInfoPtr_m_Current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr_m_Current;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAsset_Protected_Virtual_Void_GameObject_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
