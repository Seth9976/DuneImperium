using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001A9 RID: 425
	public class ActivateWithSpecificRuleModifier : VersionedView<IAttribute<List<int>>>
	{
		// Token: 0x060012CD RID: 4813 RVA: 0x00051368 File Offset: 0x0004F568
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateWithSpecificRuleModifier()
		{
			Il2CppClassPointerStore<ActivateWithSpecificRuleModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "ActivateWithSpecificRuleModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateWithSpecificRuleModifier>.NativeClassPtr);
			ActivateWithSpecificRuleModifier.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateWithSpecificRuleModifier>.NativeClassPtr, "modifier");
			ActivateWithSpecificRuleModifier.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivateWithSpecificRuleModifier>.NativeClassPtr, "root");
			ActivateWithSpecificRuleModifier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateWithSpecificRuleModifier>.NativeClassPtr, 100665862);
			ActivateWithSpecificRuleModifier.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateWithSpecificRuleModifier>.NativeClassPtr, 100665863);
			ActivateWithSpecificRuleModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateWithSpecificRuleModifier>.NativeClassPtr, 100665864);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000513FC File Offset: 0x0004F5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712420, XrefRangeEnd = 712436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivateWithSpecificRuleModifier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00051438 File Offset: 0x0004F638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712436, XrefRangeEnd = 712446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivateWithSpecificRuleModifier.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00051474 File Offset: 0x0004F674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712446, XrefRangeEnd = 712449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateWithSpecificRuleModifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateWithSpecificRuleModifier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateWithSpecificRuleModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0000BB88 File Offset: 0x00009D88
		public ActivateWithSpecificRuleModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x000514B0 File Offset: 0x0004F6B0
		// (set) Token: 0x060012D3 RID: 4819 RVA: 0x0000BB91 File Offset: 0x00009D91
		public unsafe int modifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateWithSpecificRuleModifier.NativeFieldInfoPtr_modifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateWithSpecificRuleModifier.NativeFieldInfoPtr_modifier)) = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000514D8 File Offset: 0x0004F6D8
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x0000BBAC File Offset: 0x00009DAC
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateWithSpecificRuleModifier.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivateWithSpecificRuleModifier.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_modifier;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
