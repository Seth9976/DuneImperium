using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D2 RID: 466
	public class StyleVariableContext : Object
	{
		// Token: 0x0600242D RID: 9261 RVA: 0x000A2730 File Offset: 0x000A0930
		// Note: this type is marked as 'beforefieldinit'.
		static StyleVariableContext()
		{
			Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleVariableContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr);
			StyleVariableContext.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "none");
			StyleVariableContext.NativeFieldInfoPtr_m_VariableHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "m_VariableHash");
			StyleVariableContext.NativeFieldInfoPtr_m_Variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "m_Variables");
			StyleVariableContext.NativeFieldInfoPtr_m_SortedHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "m_SortedHash");
			StyleVariableContext.NativeFieldInfoPtr_m_UnsortedHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "m_UnsortedHash");
			StyleVariableContext.NativeMethodInfoPtr_Add_Public_Void_StyleVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, 100668783);
			StyleVariableContext.NativeMethodInfoPtr_AddInitialRange_Public_Void_StyleVariableContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, 100668784);
			StyleVariableContext.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, 100668785);
			StyleVariableContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, 100668786);
			StyleVariableContext.NativeMethodInfoPtr__ctor_Public_Void_StyleVariableContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, 100668787);
			StyleVariableContext.NativeMethodInfoPtr_TryFindVariable_Public_Boolean_String_byref_StyleVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, 100668788);
			StyleVariableContext.NativeMethodInfoPtr_GetVariableHash_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, 100668789);
			StyleVariableContext.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_byref___c__DisplayClass7_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, 100668791);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x000A2864 File Offset: 0x000A0A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338117, RefRangeEnd = 338118, XrefRangeStart = 338083, XrefRangeEnd = 338117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(StyleVariable sv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sv));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableContext.NativeMethodInfoPtr_Add_Public_Void_StyleVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x000A28AC File Offset: 0x000A0AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338131, RefRangeEnd = 338132, XrefRangeStart = 338118, XrefRangeEnd = 338131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInitialRange(StyleVariableContext other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableContext.NativeMethodInfoPtr_AddInitialRange_Public_Void_StyleVariableContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x000A28F0 File Offset: 0x000A0AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338136, RefRangeEnd = 338137, XrefRangeStart = 338132, XrefRangeEnd = 338136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableContext.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x000A2924 File Offset: 0x000A0B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338157, RefRangeEnd = 338158, XrefRangeStart = 338137, XrefRangeEnd = 338157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleVariableContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x000A2960 File Offset: 0x000A0B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338179, RefRangeEnd = 338180, XrefRangeStart = 338158, XrefRangeEnd = 338179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleVariableContext(StyleVariableContext other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableContext.NativeMethodInfoPtr__ctor_Public_Void_StyleVariableContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x000A29AC File Offset: 0x000A0BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338180, XrefRangeEnd = 338185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFindVariable(string name, out StyleVariable v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleVariableContext.NativeMethodInfoPtr_TryFindVariable_Public_Boolean_String_byref_StyleVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			v = ((intPtr4 == 0) ? null : new StyleVariable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x000A2A1C File Offset: 0x000A0C1C
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 334600, RefRangeEnd = 334642, XrefRangeStart = 334600, XrefRangeEnd = 334642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVariableHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableContext.NativeMethodInfoPtr_GetVariableHash_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x000A2A58 File Offset: 0x000A0C58
		[CallerCount(0)]
		public unsafe static int Method_Internal_Static_Int32_Int32_byref___c__DisplayClass7_0_PDM_0(int index, ref StyleVariableContext.__c__DisplayClass7_0 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableContext.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_byref___c__DisplayClass7_0_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0000EE1E File Offset: 0x0000D01E
		public StyleVariableContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x000A2AA4 File Offset: 0x000A0CA4
		// (set) Token: 0x06002438 RID: 9272 RVA: 0x0000EE27 File Offset: 0x0000D027
		public unsafe static StyleVariableContext none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleVariableContext.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleVariableContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleVariableContext.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x000A2ACC File Offset: 0x000A0CCC
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x0000EE39 File Offset: 0x0000D039
		public unsafe int m_VariableHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_VariableHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_VariableHash)) = value;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x000A2AF4 File Offset: 0x000A0CF4
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x0000EE54 File Offset: 0x0000D054
		public unsafe List<StyleVariable> m_Variables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_Variables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_Variables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x000A2B24 File Offset: 0x000A0D24
		// (set) Token: 0x0600243E RID: 9278 RVA: 0x0000EE73 File Offset: 0x0000D073
		public unsafe List<int> m_SortedHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_SortedHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_SortedHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x000A2B54 File Offset: 0x000A0D54
		// (set) Token: 0x06002440 RID: 9280 RVA: 0x0000EE92 File Offset: 0x0000D092
		public unsafe List<int> m_UnsortedHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_UnsortedHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_UnsortedHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0000EEB1 File Offset: 0x0000D0B1
		public List<StyleVariable> variables
		{
			get
			{
				return this.m_Variables;
			}
		}

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeFieldInfoPtr_m_VariableHash;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeFieldInfoPtr_m_Variables;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedHash;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeFieldInfoPtr_m_UnsortedHash;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_StyleVariable_0;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeMethodInfoPtr_AddInitialRange_Public_Void_StyleVariableContext_0;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleVariableContext_0;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_TryFindVariable_Public_Boolean_String_byref_StyleVariable_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_GetVariableHash_Public_Int32_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_byref___c__DisplayClass7_0_PDM_0;

		// Token: 0x020004E3 RID: 1251
		[ObfuscatedName("UnityEngine.UIElements.StyleVariableContext+<>c__DisplayClass7_0")]
		[StructLayout(2)]
		public struct __c__DisplayClass7_0
		{
			// Token: 0x06003F1C RID: 16156 RVA: 0x0001A719 File Offset: 0x00018919
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<StyleVariableContext.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleVariableContext.__c__DisplayClass7_0>.NativeClassPtr);
				StyleVariableContext.__c__DisplayClass7_0.NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext.__c__DisplayClass7_0>.NativeClassPtr, "hash");
			}

			// Token: 0x06003F1D RID: 16157 RVA: 0x0001A74D File Offset: 0x0001894D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleVariableContext.__c__DisplayClass7_0>.NativeClassPtr, ref this));
			}

			// Token: 0x04002C9F RID: 11423
			private static readonly IntPtr NativeFieldInfoPtr_hash;

			// Token: 0x04002CA0 RID: 11424
			[FieldOffset(0)]
			public int hash;
		}
	}
}
