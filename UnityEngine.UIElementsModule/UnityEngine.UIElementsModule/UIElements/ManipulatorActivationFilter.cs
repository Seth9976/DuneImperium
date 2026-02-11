using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000148 RID: 328
	[StructLayout(2)]
	public struct ManipulatorActivationFilter
	{
		// Token: 0x06001844 RID: 6212 RVA: 0x00072F94 File Offset: 0x00071194
		// Note: this type is marked as 'beforefieldinit'.
		static ManipulatorActivationFilter()
		{
			Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ManipulatorActivationFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr);
			ManipulatorActivationFilter.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, "<button>k__BackingField");
			ManipulatorActivationFilter.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, "<modifiers>k__BackingField");
			ManipulatorActivationFilter.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, "<clickCount>k__BackingField");
			ManipulatorActivationFilter.NativeMethodInfoPtr_get_button_Public_get_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666895);
			ManipulatorActivationFilter.NativeMethodInfoPtr_set_button_Public_set_Void_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666896);
			ManipulatorActivationFilter.NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666897);
			ManipulatorActivationFilter.NativeMethodInfoPtr_set_modifiers_Public_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666898);
			ManipulatorActivationFilter.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666899);
			ManipulatorActivationFilter.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666900);
			ManipulatorActivationFilter.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ManipulatorActivationFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666901);
			ManipulatorActivationFilter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666902);
			ManipulatorActivationFilter.NativeMethodInfoPtr_Matches_Public_Boolean_IMouseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666903);
			ManipulatorActivationFilter.NativeMethodInfoPtr_HasModifiers_Private_Boolean_IMouseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666904);
			ManipulatorActivationFilter.NativeMethodInfoPtr_Matches_Public_Boolean_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666905);
			ManipulatorActivationFilter.NativeMethodInfoPtr_HasModifiers_Private_Boolean_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666906);
			ManipulatorActivationFilter.NativeMethodInfoPtr_MatchModifiers_Private_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, 100666907);
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00073104 File Offset: 0x00071304
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x00073134 File Offset: 0x00071334
		public unsafe MouseButton button
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_get_button_Public_get_MouseButton_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_set_button_Public_set_Void_MouseButton_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00073168 File Offset: 0x00071368
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x00073198 File Offset: 0x00071398
		public unsafe EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_set_modifiers_Public_set_Void_EventModifiers_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x000731CC File Offset: 0x000713CC
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x0000B27F File Offset: 0x0000947F
		public unsafe int clickCount
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._clickCount_k__BackingField = value;
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000731FC File Offset: 0x000713FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320176, XrefRangeEnd = 320179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00073240 File Offset: 0x00071440
		[CallerCount(0)]
		public unsafe bool Equals(ManipulatorActivationFilter other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ManipulatorActivationFilter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00073280 File Offset: 0x00071480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320179, XrefRangeEnd = 320182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x000732B0 File Offset: 0x000714B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320182, XrefRangeEnd = 320188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Matches(IMouseEvent e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_Matches_Public_Boolean_IMouseEvent_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x000732F4 File Offset: 0x000714F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320198, RefRangeEnd = 320199, XrefRangeStart = 320188, XrefRangeEnd = 320198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasModifiers(IMouseEvent e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_HasModifiers_Private_Boolean_IMouseEvent_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00073338 File Offset: 0x00071538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320205, RefRangeEnd = 320206, XrefRangeStart = 320199, XrefRangeEnd = 320205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Matches(IPointerEvent e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_Matches_Public_Boolean_IPointerEvent_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0007337C File Offset: 0x0007157C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320206, XrefRangeEnd = 320216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasModifiers(IPointerEvent e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_HasModifiers_Private_Boolean_IPointerEvent_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x000733C0 File Offset: 0x000715C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320216, RefRangeEnd = 320218, XrefRangeStart = 320216, XrefRangeEnd = 320216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctrl;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref command;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManipulatorActivationFilter.NativeMethodInfoPtr_MatchModifiers_Private_Boolean_Boolean_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0000B26D File Offset: 0x0000946D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManipulatorActivationFilter>.NativeClassPtr, ref this));
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00073428 File Offset: 0x00071628
		public static bool operator ==(ManipulatorActivationFilter filter1, ManipulatorActivationFilter filter2)
		{
			return filter1.Equals(filter2);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00073444 File Offset: 0x00071644
		public static bool operator !=(ManipulatorActivationFilter filter1, ManipulatorActivationFilter filter2)
		{
			return !(filter1 == filter2);
		}

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_MouseButton_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_MouseButton_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Public_set_Void_EventModifiers_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ManipulatorActivationFilter_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_IMouseEvent_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_HasModifiers_Private_Boolean_IMouseEvent_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_IPointerEvent_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_HasModifiers_Private_Boolean_IPointerEvent_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_MatchModifiers_Private_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x040010B0 RID: 4272
		[FieldOffset(0)]
		public MouseButton _button_k__BackingField;

		// Token: 0x040010B1 RID: 4273
		[FieldOffset(4)]
		public EventModifiers _modifiers_k__BackingField;

		// Token: 0x040010B2 RID: 4274
		[FieldOffset(8)]
		public int _clickCount_k__BackingField;
	}
}
