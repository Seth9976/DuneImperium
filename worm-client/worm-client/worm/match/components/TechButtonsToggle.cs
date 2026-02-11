using System;
using boardgames.utils;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001C3 RID: 451
	public class TechButtonsToggle : MonoBehaviour
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x000543DC File Offset: 0x000525DC
		// Note: this type is marked as 'beforefieldinit'.
		static TechButtonsToggle()
		{
			Il2CppClassPointerStore<TechButtonsToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "TechButtonsToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TechButtonsToggle>.NativeClassPtr);
			TechButtonsToggle.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechButtonsToggle>.NativeClassPtr, "toggle");
			TechButtonsToggle.NativeFieldInfoPtr_iapStoreBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechButtonsToggle>.NativeClassPtr, "iapStoreBehaviour");
			TechButtonsToggle.NativeFieldInfoPtr_productUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechButtonsToggle>.NativeClassPtr, "productUtils");
			TechButtonsToggle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechButtonsToggle>.NativeClassPtr, 100666013);
			TechButtonsToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechButtonsToggle>.NativeClassPtr, 100666014);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00054470 File Offset: 0x00052670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713341, XrefRangeEnd = 713384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TechButtonsToggle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x000544A4 File Offset: 0x000526A4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TechButtonsToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TechButtonsToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TechButtonsToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0000C259 File Offset: 0x0000A459
		public TechButtonsToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x000544E0 File Offset: 0x000526E0
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x0000C262 File Offset: 0x0000A462
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TechButtonsToggle.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TechButtonsToggle.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x00054510 File Offset: 0x00052710
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x0000C281 File Offset: 0x0000A481
		public unsafe IAPStoreBehaviour iapStoreBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TechButtonsToggle.NativeFieldInfoPtr_iapStoreBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TechButtonsToggle.NativeFieldInfoPtr_iapStoreBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00054540 File Offset: 0x00052740
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		public unsafe ProductUtils productUtils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TechButtonsToggle.NativeFieldInfoPtr_productUtils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductUtils>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TechButtonsToggle.NativeFieldInfoPtr_productUtils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeFieldInfoPtr_iapStoreBehaviour;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeFieldInfoPtr_productUtils;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CC RID: 972
		[ObfuscatedName("worm.match.components.TechButtonsToggle+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600275F RID: 10079 RVA: 0x0008F988 File Offset: 0x0008DB88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TechButtonsToggle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TechButtonsToggle>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TechButtonsToggle.__c>.NativeClassPtr);
				TechButtonsToggle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechButtonsToggle.__c>.NativeClassPtr, "<>9");
				TechButtonsToggle.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechButtonsToggle.__c>.NativeClassPtr, "<>9__3_0");
				TechButtonsToggle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechButtonsToggle.__c>.NativeClassPtr, 100666016);
				TechButtonsToggle.__c.NativeMethodInfoPtr__Start_b__3_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TechButtonsToggle.__c>.NativeClassPtr, 100666017);
			}

			// Token: 0x06002760 RID: 10080 RVA: 0x0008FA04 File Offset: 0x0008DC04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TechButtonsToggle.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TechButtonsToggle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002761 RID: 10081 RVA: 0x0008FA40 File Offset: 0x0008DC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713333, XrefRangeEnd = 713341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__3_0(bool isOn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isOn;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TechButtonsToggle.__c.NativeMethodInfoPtr__Start_b__3_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002762 RID: 10082 RVA: 0x00015A81 File Offset: 0x00013C81
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x06002763 RID: 10083 RVA: 0x0008FA80 File Offset: 0x0008DC80
			// (set) Token: 0x06002764 RID: 10084 RVA: 0x00015A8A File Offset: 0x00013C8A
			public unsafe static TechButtonsToggle.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TechButtonsToggle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TechButtonsToggle.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TechButtonsToggle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x06002765 RID: 10085 RVA: 0x0008FAA8 File Offset: 0x0008DCA8
			// (set) Token: 0x06002766 RID: 10086 RVA: 0x00015A9C File Offset: 0x00013C9C
			public unsafe static UnityAction<bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TechButtonsToggle.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TechButtonsToggle.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016AE RID: 5806
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016AF RID: 5807
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040016B0 RID: 5808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016B1 RID: 5809
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__3_0_Internal_Void_Boolean_0;
		}
	}
}
