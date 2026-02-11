using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;
using UnityEngine.EventSystems;

namespace boardgames.moz
{
	// Token: 0x0200010F RID: 271
	public class ContainerViewMoz : BaseMoz
	{
		// Token: 0x06000C2B RID: 3115 RVA: 0x0004414C File Offset: 0x0004234C
		// Note: this type is marked as 'beforefieldinit'.
		static ContainerViewMoz()
		{
			Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "ContainerViewMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr);
			ContainerViewMoz.NativeFieldInfoPtr_mozContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, "mozContainerPrefab");
			ContainerViewMoz.NativeFieldInfoPtr_mozContainerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, "mozContainerInstance");
			ContainerViewMoz.NativeFieldInfoPtr_overlayCanvasRectT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, "overlayCanvasRectT");
			ContainerViewMoz.NativeFieldInfoPtr_parentPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, "parentPile");
			ContainerViewMoz.NativeFieldInfoPtr_mozPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, "mozPile");
			ContainerViewMoz.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, 100665094);
			ContainerViewMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, 100665095);
			ContainerViewMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, 100665096);
			ContainerViewMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, 100665097);
			ContainerViewMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, 100665098);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00044244 File Offset: 0x00042444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509514, XrefRangeEnd = 509523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerViewMoz.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00044278 File Offset: 0x00042478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509523, XrefRangeEnd = 509570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerViewMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000442C8 File Offset: 0x000424C8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerViewMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00044304 File Offset: 0x00042504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509570, XrefRangeEnd = 509581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContainerViewMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00044340 File Offset: 0x00042540
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 509296, RefRangeEnd = 509303, XrefRangeStart = 509296, XrefRangeEnd = 509303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerViewMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerViewMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00007DB9 File Offset: 0x00005FB9
		public ContainerViewMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0004437C File Offset: 0x0004257C
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x00007DC2 File Offset: 0x00005FC2
		public unsafe GameObject mozContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_mozContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_mozContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x000443AC File Offset: 0x000425AC
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x00007DE1 File Offset: 0x00005FE1
		public unsafe GameObject mozContainerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_mozContainerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_mozContainerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x000443DC File Offset: 0x000425DC
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x00007E00 File Offset: 0x00006000
		public unsafe RectTransform overlayCanvasRectT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_overlayCanvasRectT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_overlayCanvasRectT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0004440C File Offset: 0x0004260C
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00007E1F File Offset: 0x0000601F
		public unsafe ContainerView parentPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_parentPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_parentPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0004443C File Offset: 0x0004263C
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00007E3E File Offset: 0x0000603E
		public unsafe ContainerView mozPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_mozPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.NativeFieldInfoPtr_mozPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_mozContainerPrefab;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_mozContainerInstance;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_overlayCanvasRectT;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr_parentPile;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeFieldInfoPtr_mozPile;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000351 RID: 849
		[ObfuscatedName("boardgames.moz.ContainerViewMoz+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600281A RID: 10266 RVA: 0x000A08B8 File Offset: 0x0009EAB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ContainerViewMoz.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerViewMoz>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerViewMoz.__c__DisplayClass6_0>.NativeClassPtr);
				ContainerViewMoz.__c__DisplayClass6_0.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerViewMoz.__c__DisplayClass6_0>.NativeClassPtr, "view");
				ContainerViewMoz.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewMoz.__c__DisplayClass6_0>.NativeClassPtr, 100665099);
				ContainerViewMoz.__c__DisplayClass6_0.NativeMethodInfoPtr__initMoz_b__0_Internal_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewMoz.__c__DisplayClass6_0>.NativeClassPtr, 100665100);
			}

			// Token: 0x0600281B RID: 10267 RVA: 0x000A0920 File Offset: 0x0009EB20
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerViewMoz.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerViewMoz.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600281C RID: 10268 RVA: 0x000A095C File Offset: 0x0009EB5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509507, XrefRangeEnd = 509514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initMoz_b__0(UnitView mozPileView)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mozPileView);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerViewMoz.__c__DisplayClass6_0.NativeMethodInfoPtr__initMoz_b__0_Internal_Boolean_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600281D RID: 10269 RVA: 0x00014BE3 File Offset: 0x00012DE3
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x0600281E RID: 10270 RVA: 0x000A09AC File Offset: 0x0009EBAC
			// (set) Token: 0x0600281F RID: 10271 RVA: 0x00014BEC File Offset: 0x00012DEC
			public unsafe UnitView view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.__c__DisplayClass6_0.NativeFieldInfoPtr_view);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewMoz.__c__DisplayClass6_0.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001925 RID: 6437
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x04001926 RID: 6438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001927 RID: 6439
			private static readonly IntPtr NativeMethodInfoPtr__initMoz_b__0_Internal_Boolean_UnitView_0;
		}
	}
}
