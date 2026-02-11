using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	// Token: 0x0200007F RID: 127
	public class Selector : FormatItem
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x0002028C File Offset: 0x0001E48C
		// Note: this type is marked as 'beforefieldinit'.
		static Selector()
		{
			Il2CppClassPointerStore<Selector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Parsing", "Selector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Selector>.NativeClassPtr);
			Selector.NativeFieldInfoPtr_m_Operator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selector>.NativeClassPtr, "m_Operator");
			Selector.NativeFieldInfoPtr_operatorStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selector>.NativeClassPtr, "operatorStart");
			Selector.NativeFieldInfoPtr__SelectorIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selector>.NativeClassPtr, "<SelectorIndex>k__BackingField");
			Selector.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100664428);
			Selector.NativeMethodInfoPtr_get_SelectorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100664429);
			Selector.NativeMethodInfoPtr_set_SelectorIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100664430);
			Selector.NativeMethodInfoPtr_get_Operator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100664431);
			Selector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100664432);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0002035C File Offset: 0x0001E55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074150, XrefRangeEnd = 1074155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selector.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00020398 File Offset: 0x0001E598
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x000203D4 File Offset: 0x0001E5D4
		public unsafe int SelectorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selector.NativeMethodInfoPtr_get_SelectorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selector.NativeMethodInfoPtr_set_SelectorIndex_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00020414 File Offset: 0x0001E614
		public unsafe string Operator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074155, XrefRangeEnd = 1074157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selector.NativeMethodInfoPtr_get_Operator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0002044C File Offset: 0x0001E64C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Selector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00004566 File Offset: 0x00002766
		public Selector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00020488 File Offset: 0x0001E688
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x0000456F File Offset: 0x0000276F
		public unsafe string m_Operator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr_m_Operator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr_m_Operator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x000204B0 File Offset: 0x0001E6B0
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x0000458E File Offset: 0x0000278E
		public unsafe int operatorStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr_operatorStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr_operatorStart)) = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x000204D8 File Offset: 0x0001E6D8
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x000045A9 File Offset: 0x000027A9
		public unsafe int _SelectorIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr__SelectorIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr__SelectorIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_m_Operator;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_operatorStart;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr__SelectorIndex_k__BackingField;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectorIndex_Public_get_Int32_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectorIndex_Internal_set_Void_Int32_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_get_Operator_Public_get_String_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
