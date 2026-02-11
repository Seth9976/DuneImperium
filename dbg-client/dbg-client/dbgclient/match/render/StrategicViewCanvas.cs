using System;
using boardgames.camera;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dbgclient.match.render
{
	// Token: 0x020000AA RID: 170
	public class StrategicViewCanvas : MonoBehaviour
	{
		// Token: 0x060006BB RID: 1723 RVA: 0x00032D74 File Offset: 0x00030F74
		// Note: this type is marked as 'beforefieldinit'.
		static StrategicViewCanvas()
		{
			Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.match.render", "StrategicViewCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr);
			StrategicViewCanvas.NativeFieldInfoPtr_canvasTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, "canvasTransform");
			StrategicViewCanvas.NativeFieldInfoPtr_canvasCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, "canvasCamera");
			StrategicViewCanvas.NativeFieldInfoPtr_cameraControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, "cameraControl");
			StrategicViewCanvas.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, "elements");
			StrategicViewCanvas.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, 100664357);
			StrategicViewCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, 100664358);
			StrategicViewCanvas.NativeMethodInfoPtr_RegisterElement_Public_Void_StrategicViewElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, 100664359);
			StrategicViewCanvas.NativeMethodInfoPtr_UnregisterElement_Public_Void_StrategicViewElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, 100664360);
			StrategicViewCanvas.NativeMethodInfoPtr_sortIcons_Private_Static_Int32_StrategicViewElement_StrategicViewElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, 100664361);
			StrategicViewCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, 100664362);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00032E6C File Offset: 0x0003106C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503745, XrefRangeEnd = 503762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewCanvas.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00032EA0 File Offset: 0x000310A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503762, XrefRangeEnd = 503772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00032ED4 File Offset: 0x000310D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503772, XrefRangeEnd = 503793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterElement(StrategicViewElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewCanvas.NativeMethodInfoPtr_RegisterElement_Public_Void_StrategicViewElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00032F18 File Offset: 0x00031118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503793, XrefRangeEnd = 503811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterElement(StrategicViewElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewCanvas.NativeMethodInfoPtr_UnregisterElement_Public_Void_StrategicViewElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00032F5C File Offset: 0x0003115C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503811, XrefRangeEnd = 503813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int sortIcons(StrategicViewElement a, StrategicViewElement b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewCanvas.NativeMethodInfoPtr_sortIcons_Private_Static_Int32_StrategicViewElement_StrategicViewElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00032FB0 File Offset: 0x000311B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503813, XrefRangeEnd = 503821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StrategicViewCanvas()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicViewCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00005116 File Offset: 0x00003316
		public StrategicViewCanvas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00032FEC File Offset: 0x000311EC
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x0000511F File Offset: 0x0000331F
		public unsafe RectTransform canvasTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewCanvas.NativeFieldInfoPtr_canvasTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewCanvas.NativeFieldInfoPtr_canvasTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0003301C File Offset: 0x0003121C
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x0000513E File Offset: 0x0000333E
		public unsafe Camera canvasCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewCanvas.NativeFieldInfoPtr_canvasCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewCanvas.NativeFieldInfoPtr_canvasCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0003304C File Offset: 0x0003124C
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x0000515D File Offset: 0x0000335D
		public unsafe IStrategicViewCamera cameraControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewCanvas.NativeFieldInfoPtr_cameraControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStrategicViewCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewCanvas.NativeFieldInfoPtr_cameraControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0003307C File Offset: 0x0003127C
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x0000517C File Offset: 0x0000337C
		public unsafe List<StrategicViewElement> elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewCanvas.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StrategicViewElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategicViewCanvas.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_canvasTransform;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_canvasCamera;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_cameraControl;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_RegisterElement_Public_Void_StrategicViewElement_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterElement_Public_Void_StrategicViewElement_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_sortIcons_Private_Static_Int32_StrategicViewElement_StrategicViewElement_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200031A RID: 794
		[ObfuscatedName("dbgclient.match.render.StrategicViewCanvas+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x06002586 RID: 9606 RVA: 0x000137A0 File Offset: 0x000119A0
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<StrategicViewCanvas.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StrategicViewCanvas>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrategicViewCanvas.__O>.NativeClassPtr);
				StrategicViewCanvas.__O.NativeFieldInfoPtr__0___sortIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicViewCanvas.__O>.NativeClassPtr, "<0>__sortIcons");
			}

			// Token: 0x06002587 RID: 9607 RVA: 0x000137D4 File Offset: 0x000119D4
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x06002588 RID: 9608 RVA: 0x00098BA4 File Offset: 0x00096DA4
			// (set) Token: 0x06002589 RID: 9609 RVA: 0x000137DD File Offset: 0x000119DD
			public unsafe static Comparison<StrategicViewElement> _0___sortIcons
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StrategicViewCanvas.__O.NativeFieldInfoPtr__0___sortIcons, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<StrategicViewElement>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StrategicViewCanvas.__O.NativeFieldInfoPtr__0___sortIcons, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400178D RID: 6029
			private static readonly IntPtr NativeFieldInfoPtr__0___sortIcons;
		}
	}
}
