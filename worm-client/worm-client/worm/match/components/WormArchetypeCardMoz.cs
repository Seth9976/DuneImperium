using System;
using boardgames.moz;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x020001D3 RID: 467
	public class WormArchetypeCardMoz : CardMoz
	{
		// Token: 0x060014A7 RID: 5287 RVA: 0x00056C98 File Offset: 0x00054E98
		// Note: this type is marked as 'beforefieldinit'.
		static WormArchetypeCardMoz()
		{
			Il2CppClassPointerStore<WormArchetypeCardMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormArchetypeCardMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeCardMoz>.NativeClassPtr);
			WormArchetypeCardMoz.NativeFieldInfoPtr_entityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCardMoz>.NativeClassPtr, "entityView");
			WormArchetypeCardMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCardMoz>.NativeClassPtr, 100666126);
			WormArchetypeCardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCardMoz>.NativeClassPtr, 100666127);
			WormArchetypeCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCardMoz>.NativeClassPtr, 100666128);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00056D18 File Offset: 0x00054F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714430, XrefRangeEnd = 714435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCardMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00056D54 File Offset: 0x00054F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714435, XrefRangeEnd = 714441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00056DA4 File Offset: 0x00054FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510310, RefRangeEnd = 510311, XrefRangeStart = 510310, XrefRangeEnd = 510311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormArchetypeCardMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypeCardMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		public WormArchetypeCardMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00056DE0 File Offset: 0x00054FE0
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x0000CA55 File Offset: 0x0000AC55
		public unsafe EntityView entityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCardMoz.NativeFieldInfoPtr_entityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCardMoz.NativeFieldInfoPtr_entityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeFieldInfoPtr_entityView;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
