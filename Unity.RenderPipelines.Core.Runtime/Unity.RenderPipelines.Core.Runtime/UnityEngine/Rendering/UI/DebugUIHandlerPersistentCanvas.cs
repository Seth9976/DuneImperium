using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x02000132 RID: 306
	public class DebugUIHandlerPersistentCanvas : MonoBehaviour
	{
		// Token: 0x060013DF RID: 5087 RVA: 0x00058978 File Offset: 0x00056B78
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerPersistentCanvas()
		{
			Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerPersistentCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr);
			DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, "panel");
			DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_valuePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, "valuePrefab");
			DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, "m_Items");
			DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_m_ValueTupleWidgets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, "m_ValueTupleWidgets");
			DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr_Toggle_Internal_Void_Value_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, 100666165);
			DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr_Toggle_Internal_Void_ValueTuple_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, 100666166);
			DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, 100666167);
			DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, 100666168);
			DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, 100666169);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00058A5C File Offset: 0x00056C5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 981051, RefRangeEnd = 981053, XrefRangeStart = 981020, XrefRangeEnd = 981051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Toggle(DebugUI.Value widget, string displayName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr_Toggle_Internal_Void_Value_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00058AB0 File Offset: 0x00056CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 981081, RefRangeEnd = 981082, XrefRangeStart = 981053, XrefRangeEnd = 981081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Toggle(DebugUI.ValueTuple widget, Nullable<int> forceTupleIndex = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forceTupleIndex));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr_Toggle_Internal_Void_ValueTuple_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00058B0C File Offset: 0x00056D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981082, XrefRangeEnd = 981083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00058B48 File Offset: 0x00056D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981083, XrefRangeEnd = 981104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00058B7C File Offset: 0x00056D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981104, XrefRangeEnd = 981119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerPersistentCanvas()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPersistentCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0000A156 File Offset: 0x00008356
		public DebugUIHandlerPersistentCanvas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x00058BB8 File Offset: 0x00056DB8
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x0000A15F File Offset: 0x0000835F
		public unsafe RectTransform panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00058BE8 File Offset: 0x00056DE8
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x0000A17E File Offset: 0x0000837E
		public unsafe RectTransform valuePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_valuePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_valuePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00058C18 File Offset: 0x00056E18
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x0000A19D File Offset: 0x0000839D
		public unsafe List<DebugUIHandlerValue> m_Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_m_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DebugUIHandlerValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00058C48 File Offset: 0x00056E48
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x0000A1BC File Offset: 0x000083BC
		public unsafe List<DebugUI.ValueTuple> m_ValueTupleWidgets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_m_ValueTupleWidgets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DebugUI.ValueTuple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.NativeFieldInfoPtr_m_ValueTupleWidgets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeFieldInfoPtr_panel;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeFieldInfoPtr_valuePrefab;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeFieldInfoPtr_m_Items;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeFieldInfoPtr_m_ValueTupleWidgets;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Internal_Void_Value_String_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Internal_Void_ValueTuple_Nullable_1_Int32_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021A RID: 538
		[ObfuscatedName("UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvas+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001B56 RID: 6998 RVA: 0x0006FA70 File Offset: 0x0006DC70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0>.NativeClassPtr);
				DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0.NativeFieldInfoPtr_widget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0>.NativeClassPtr, "widget");
				DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0>.NativeClassPtr, 100666170);
				DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0.NativeMethodInfoPtr__Toggle_b__0_Internal_Boolean_DebugUIHandlerValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0>.NativeClassPtr, 100666171);
			}

			// Token: 0x06001B57 RID: 6999 RVA: 0x0006FAD8 File Offset: 0x0006DCD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B58 RID: 7000 RVA: 0x0006FB14 File Offset: 0x0006DD14
			[CallerCount(0)]
			public unsafe bool _Toggle_b__0(DebugUIHandlerValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0.NativeMethodInfoPtr__Toggle_b__0_Internal_Boolean_DebugUIHandlerValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B59 RID: 7001 RVA: 0x0000DA44 File Offset: 0x0000BC44
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0006FB64 File Offset: 0x0006DD64
			// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0000DA4D File Offset: 0x0000BC4D
			public unsafe DebugUI.Value widget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0.NativeFieldInfoPtr_widget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Value>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.__c__DisplayClass3_0.NativeFieldInfoPtr_widget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013E8 RID: 5096
			private static readonly IntPtr NativeFieldInfoPtr_widget;

			// Token: 0x040013E9 RID: 5097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013EA RID: 5098
			private static readonly IntPtr NativeMethodInfoPtr__Toggle_b__0_Internal_Boolean_DebugUIHandlerValue_0;
		}

		// Token: 0x0200021B RID: 539
		[ObfuscatedName("UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvas+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06001B5C RID: 7004 RVA: 0x0006FB94 File Offset: 0x0006DD94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0>.NativeClassPtr);
				DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0.NativeFieldInfoPtr_widget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0>.NativeClassPtr, "widget");
				DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0>.NativeClassPtr, 100666172);
				DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0.NativeMethodInfoPtr__Toggle_b__0_Internal_Boolean_ValueTuple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0>.NativeClassPtr, 100666173);
			}

			// Token: 0x06001B5D RID: 7005 RVA: 0x0006FBFC File Offset: 0x0006DDFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B5E RID: 7006 RVA: 0x0006FC38 File Offset: 0x0006DE38
			[CallerCount(0)]
			public unsafe bool _Toggle_b__0(DebugUI.ValueTuple x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0.NativeMethodInfoPtr__Toggle_b__0_Internal_Boolean_ValueTuple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B5F RID: 7007 RVA: 0x0000DA6C File Offset: 0x0000BC6C
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0006FC88 File Offset: 0x0006DE88
			// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0000DA75 File Offset: 0x0000BC75
			public unsafe DebugUI.ValueTuple widget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0.NativeFieldInfoPtr_widget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.ValueTuple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerPersistentCanvas.__c__DisplayClass5_0.NativeFieldInfoPtr_widget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013EB RID: 5099
			private static readonly IntPtr NativeFieldInfoPtr_widget;

			// Token: 0x040013EC RID: 5100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013ED RID: 5101
			private static readonly IntPtr NativeMethodInfoPtr__Toggle_b__0_Internal_Boolean_ValueTuple_0;
		}
	}
}
