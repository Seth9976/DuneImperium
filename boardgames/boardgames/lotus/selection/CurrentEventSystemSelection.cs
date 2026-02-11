using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace lotus.selection
{
	// Token: 0x020000E0 RID: 224
	public class CurrentEventSystemSelection : MonoBehaviour
	{
		// Token: 0x06000B16 RID: 2838 RVA: 0x00034564 File Offset: 0x00032764
		// Note: this type is marked as 'beforefieldinit'.
		static CurrentEventSystemSelection()
		{
			Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.selection", "CurrentEventSystemSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr);
			CurrentEventSystemSelection.NativeFieldInfoPtr_cachedSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr, "cachedSelectable");
			CurrentEventSystemSelection.NativeFieldInfoPtr_cachedInputModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr, "cachedInputModule");
			CurrentEventSystemSelection.NativeFieldInfoPtr_updateManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr, "updateManager");
			CurrentEventSystemSelection.NativeMethodInfoPtr_get_CurrentSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr, 100665066);
			CurrentEventSystemSelection.NativeMethodInfoPtr_get_CurrentInputModule_Public_get_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr, 100665067);
			CurrentEventSystemSelection.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr, 100665068);
			CurrentEventSystemSelection.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr, 100665069);
			CurrentEventSystemSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr, 100665070);
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00034634 File Offset: 0x00032834
		public unsafe GameObject CurrentSelectedGameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentEventSystemSelection.NativeMethodInfoPtr_get_CurrentSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00034674 File Offset: 0x00032874
		public unsafe BaseInputModule CurrentInputModule
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentEventSystemSelection.NativeMethodInfoPtr_get_CurrentInputModule_Public_get_BaseInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr3) : null;
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x000346B4 File Offset: 0x000328B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994422, XrefRangeEnd = 994426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentEventSystemSelection.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x000346E8 File Offset: 0x000328E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994426, XrefRangeEnd = 994441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentEventSystemSelection.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0003471C File Offset: 0x0003291C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurrentEventSystemSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurrentEventSystemSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentEventSystemSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00007125 File Offset: 0x00005325
		public CurrentEventSystemSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00034758 File Offset: 0x00032958
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x0000712E File Offset: 0x0000532E
		public unsafe GameObject cachedSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentEventSystemSelection.NativeFieldInfoPtr_cachedSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentEventSystemSelection.NativeFieldInfoPtr_cachedSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00034788 File Offset: 0x00032988
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x0000714D File Offset: 0x0000534D
		public unsafe BaseInputModule cachedInputModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentEventSystemSelection.NativeFieldInfoPtr_cachedInputModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentEventSystemSelection.NativeFieldInfoPtr_cachedInputModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000347B8 File Offset: 0x000329B8
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x0000716C File Offset: 0x0000536C
		public unsafe UpdateManager updateManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentEventSystemSelection.NativeFieldInfoPtr_updateManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentEventSystemSelection.NativeFieldInfoPtr_updateManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_cachedSelectable;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_cachedInputModule;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_updateManager;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInputModule_Public_get_BaseInputModule_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
