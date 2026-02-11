using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x02000203 RID: 515
	public class WormLocationDependantMoz : WormCardMoz
	{
		// Token: 0x060016CC RID: 5836 RVA: 0x0005D424 File Offset: 0x0005B624
		// Note: this type is marked as 'beforefieldinit'.
		static WormLocationDependantMoz()
		{
			Il2CppClassPointerStore<WormLocationDependantMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormLocationDependantMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLocationDependantMoz>.NativeClassPtr);
			WormLocationDependantMoz.NativeFieldInfoPtr_alternatePile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocationDependantMoz>.NativeClassPtr, "alternatePile");
			WormLocationDependantMoz.NativeFieldInfoPtr_alternatePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocationDependantMoz>.NativeClassPtr, "alternatePrefab");
			WormLocationDependantMoz.NativeFieldInfoPtr_cachePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocationDependantMoz>.NativeClassPtr, "cachePrefab");
			WormLocationDependantMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocationDependantMoz>.NativeClassPtr, 100666466);
			WormLocationDependantMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocationDependantMoz>.NativeClassPtr, 100666467);
			WormLocationDependantMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocationDependantMoz>.NativeClassPtr, 100666468);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0005D4CC File Offset: 0x0005B6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716916, XrefRangeEnd = 716921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLocationDependantMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0005D51C File Offset: 0x0005B71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716921, XrefRangeEnd = 716923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLocationDependantMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0005D558 File Offset: 0x0005B758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716923, XrefRangeEnd = 716927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLocationDependantMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLocationDependantMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocationDependantMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0000DB33 File Offset: 0x0000BD33
		public WormLocationDependantMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x0005D594 File Offset: 0x0005B794
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x0000DB3C File Offset: 0x0000BD3C
		public unsafe string alternatePile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocationDependantMoz.NativeFieldInfoPtr_alternatePile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocationDependantMoz.NativeFieldInfoPtr_alternatePile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x0005D5BC File Offset: 0x0005B7BC
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x0000DB5B File Offset: 0x0000BD5B
		public unsafe GameObject alternatePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocationDependantMoz.NativeFieldInfoPtr_alternatePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocationDependantMoz.NativeFieldInfoPtr_alternatePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0005D5EC File Offset: 0x0005B7EC
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x0000DB7A File Offset: 0x0000BD7A
		public unsafe GameObject cachePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocationDependantMoz.NativeFieldInfoPtr_cachePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocationDependantMoz.NativeFieldInfoPtr_cachePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeFieldInfoPtr_alternatePile;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeFieldInfoPtr_alternatePrefab;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeFieldInfoPtr_cachePrefab;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
