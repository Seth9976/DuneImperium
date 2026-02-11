using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.ui
{
	// Token: 0x02000015 RID: 21
	public class LifecycleEvents : MonoBehaviour
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x00005444 File Offset: 0x00003644
		// Note: this type is marked as 'beforefieldinit'.
		static LifecycleEvents()
		{
			Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui", "LifecycleEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr);
			LifecycleEvents.NativeFieldInfoPtr_OnAwakeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, "OnAwakeEvent");
			LifecycleEvents.NativeFieldInfoPtr_OnEnableEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, "OnEnableEvent");
			LifecycleEvents.NativeFieldInfoPtr_OnStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, "OnStartEvent");
			LifecycleEvents.NativeFieldInfoPtr_OnDisableEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, "OnDisableEvent");
			LifecycleEvents.NativeFieldInfoPtr_OnDestroyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, "OnDestroyEvent");
			LifecycleEvents.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, 100663404);
			LifecycleEvents.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, 100663405);
			LifecycleEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, 100663406);
			LifecycleEvents.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, 100663407);
			LifecycleEvents.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, 100663408);
			LifecycleEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr, 100663409);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005550 File Offset: 0x00003750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifecycleEvents.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005584 File Offset: 0x00003784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifecycleEvents.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000055B8 File Offset: 0x000037B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifecycleEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000055EC File Offset: 0x000037EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifecycleEvents.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005620 File Offset: 0x00003820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254302, XrefRangeEnd = 1254309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifecycleEvents.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005654 File Offset: 0x00003854
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LifecycleEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LifecycleEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifecycleEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002587 File Offset: 0x00000787
		public LifecycleEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00005690 File Offset: 0x00003890
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002590 File Offset: 0x00000790
		public unsafe UnityEvent OnAwakeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnAwakeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnAwakeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000056C0 File Offset: 0x000038C0
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000025AF File Offset: 0x000007AF
		public unsafe UnityEvent OnEnableEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnEnableEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnEnableEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000056F0 File Offset: 0x000038F0
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000025CE File Offset: 0x000007CE
		public unsafe UnityEvent OnStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnStartEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnStartEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005720 File Offset: 0x00003920
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000025ED File Offset: 0x000007ED
		public unsafe UnityEvent OnDisableEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnDisableEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnDisableEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00005750 File Offset: 0x00003950
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000260C File Offset: 0x0000080C
		public unsafe UnityEvent OnDestroyEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnDestroyEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LifecycleEvents.NativeFieldInfoPtr_OnDestroyEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_OnAwakeEvent;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_OnEnableEvent;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_OnStartEvent;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_OnDisableEvent;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_OnDestroyEvent;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
