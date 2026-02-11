using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009A RID: 154
	public class AncestorFilter : Object
	{
		// Token: 0x06000F5D RID: 3933 RVA: 0x0005313C File Offset: 0x0005133C
		// Note: this type is marked as 'beforefieldinit'.
		static AncestorFilter()
		{
			Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "AncestorFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr);
			AncestorFilter.NativeFieldInfoPtr_m_CountingBloomFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr, "m_CountingBloomFilter");
			AncestorFilter.NativeFieldInfoPtr_m_HashStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr, "m_HashStack");
			AncestorFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr, 100665477);
			AncestorFilter.NativeMethodInfoPtr_AddHash_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr, 100665478);
			AncestorFilter.NativeMethodInfoPtr_IsCandidate_Public_Boolean_StyleComplexSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr, 100665479);
			AncestorFilter.NativeMethodInfoPtr_PushElement_Public_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr, 100665480);
			AncestorFilter.NativeMethodInfoPtr_PopElement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr, 100665481);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000531F8 File Offset: 0x000513F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307755, RefRangeEnd = 307757, XrefRangeStart = 307747, XrefRangeEnd = 307755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AncestorFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AncestorFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AncestorFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00053234 File Offset: 0x00051434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307760, RefRangeEnd = 307762, XrefRangeStart = 307757, XrefRangeEnd = 307760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddHash(int hash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AncestorFilter.NativeMethodInfoPtr_AddHash_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00053274 File Offset: 0x00051474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307762, RefRangeEnd = 307763, XrefRangeStart = 307762, XrefRangeEnd = 307762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCandidate(StyleComplexSelector complexSel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(complexSel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AncestorFilter.NativeMethodInfoPtr_IsCandidate_Public_Boolean_StyleComplexSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x000532C4 File Offset: 0x000514C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307791, RefRangeEnd = 307792, XrefRangeStart = 307763, XrefRangeEnd = 307791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushElement(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AncestorFilter.NativeMethodInfoPtr_PushElement_Public_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00053308 File Offset: 0x00051508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307802, RefRangeEnd = 307803, XrefRangeStart = 307792, XrefRangeEnd = 307802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AncestorFilter.NativeMethodInfoPtr_PopElement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00007CC5 File Offset: 0x00005EC5
		public AncestorFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0005333C File Offset: 0x0005153C
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x00007CCE File Offset: 0x00005ECE
		public unsafe CountingBloomFilter m_CountingBloomFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AncestorFilter.NativeFieldInfoPtr_m_CountingBloomFilter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AncestorFilter.NativeFieldInfoPtr_m_CountingBloomFilter)) = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00053364 File Offset: 0x00051564
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x00007CE9 File Offset: 0x00005EE9
		public unsafe Stack<int> m_HashStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AncestorFilter.NativeFieldInfoPtr_m_HashStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AncestorFilter.NativeFieldInfoPtr_m_HashStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeFieldInfoPtr_m_CountingBloomFilter;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeFieldInfoPtr_m_HashStack;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr_AddHash_Private_Void_Int32_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_IsCandidate_Public_Boolean_StyleComplexSelector_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_PushElement_Public_Void_VisualElement_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_PopElement_Public_Void_0;
	}
}
