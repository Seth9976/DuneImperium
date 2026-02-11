using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004F RID: 79
	public class BaseEventData : AbstractEventData
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x0002AAC4 File Offset: 0x00028CC4
		// Note: this type is marked as 'beforefieldinit'.
		static BaseEventData()
		{
			Il2CppClassPointerStore<BaseEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "BaseEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr);
			BaseEventData.NativeFieldInfoPtr_m_EventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, "m_EventSystem");
			BaseEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, 100664817);
			BaseEventData.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, 100664818);
			BaseEventData.NativeMethodInfoPtr_get_selectedObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, 100664819);
			BaseEventData.NativeMethodInfoPtr_set_selectedObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, 100664820);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0002AB58 File Offset: 0x00028D58
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseEventData(EventSystem eventSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0002ABA4 File Offset: 0x00028DA4
		public unsafe BaseInputModule currentInputModule
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 565625, RefRangeEnd = 565626, XrefRangeStart = 565625, XrefRangeEnd = 565626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseEventData.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr3) : null;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0002ABE4 File Offset: 0x00028DE4
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x0002AC24 File Offset: 0x00028E24
		public unsafe GameObject selectedObject
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 565624, RefRangeEnd = 565625, XrefRangeStart = 565624, XrefRangeEnd = 565625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseEventData.NativeMethodInfoPtr_get_selectedObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1094794, RefRangeEnd = 1094796, XrefRangeStart = 1094792, XrefRangeEnd = 1094794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseEventData.NativeMethodInfoPtr_set_selectedObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00005108 File Offset: 0x00003308
		public BaseEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0002AC68 File Offset: 0x00028E68
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00005111 File Offset: 0x00003311
		public unsafe EventSystem m_EventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseEventData.NativeFieldInfoPtr_m_EventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseEventData.NativeFieldInfoPtr_m_EventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSystem;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedObject_Public_get_GameObject_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedObject_Public_set_Void_GameObject_0;
	}
}
