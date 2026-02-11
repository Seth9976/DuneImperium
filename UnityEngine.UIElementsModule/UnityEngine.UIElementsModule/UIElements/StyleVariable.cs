using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D1 RID: 465
	public sealed class StyleVariable : ValueType
	{
		// Token: 0x06002422 RID: 9250 RVA: 0x000A255C File Offset: 0x000A075C
		// Note: this type is marked as 'beforefieldinit'.
		static StyleVariable()
		{
			Il2CppClassPointerStore<StyleVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr);
			StyleVariable.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr, "name");
			StyleVariable.NativeFieldInfoPtr_sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr, "sheet");
			StyleVariable.NativeFieldInfoPtr_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr, "handles");
			StyleVariable.NativeMethodInfoPtr__ctor_Public_Void_String_StyleSheet_Il2CppStructArray_1_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr, 100668781);
			StyleVariable.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr, 100668782);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x000A25F0 File Offset: 0x000A07F0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338072, RefRangeEnd = 338082, XrefRangeStart = 338062, XrefRangeEnd = 338072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleVariable(string name, StyleSheet sheet, Il2CppStructArray<StyleValueHandle> handles)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariable.NativeMethodInfoPtr__ctor_Public_Void_String_StyleSheet_Il2CppStructArray_1_StyleValueHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x000A2664 File Offset: 0x000A0864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338082, RefRangeEnd = 338083, XrefRangeStart = 338082, XrefRangeEnd = 338082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariable.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0000EDA6 File Offset: 0x0000CFA6
		public StyleVariable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0000EDAF File Offset: 0x0000CFAF
		public StyleVariable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleVariable>.NativeClassPtr))
		{
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000A26A8 File Offset: 0x000A08A8
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x0000EDC1 File Offset: 0x0000CFC1
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x000A26D0 File Offset: 0x000A08D0
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		public unsafe StyleSheet sheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_sheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x000A2700 File Offset: 0x000A0900
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x0000EDFF File Offset: 0x0000CFFF
		public unsafe Il2CppStructArray<StyleValueHandle> handles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_handles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StyleValueHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariable.NativeFieldInfoPtr_handles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeFieldInfoPtr_sheet;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeFieldInfoPtr_handles;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_StyleSheet_Il2CppStructArray_1_StyleValueHandle_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
