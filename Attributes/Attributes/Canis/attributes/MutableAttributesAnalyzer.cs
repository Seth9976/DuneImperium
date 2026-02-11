using System;
using Canis.json;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.attributes
{
	// Token: 0x0200001B RID: 27
	public sealed class MutableAttributesAnalyzer : DwdTypeAnalyzer
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00008FBC File Offset: 0x000071BC
		// Note: this type is marked as 'beforefieldinit'.
		static MutableAttributesAnalyzer()
		{
			Il2CppClassPointerStore<MutableAttributesAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "MutableAttributesAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableAttributesAnalyzer>.NativeClassPtr);
			MutableAttributesAnalyzer.NativeFieldInfoPtr_attributeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributesAnalyzer>.NativeClassPtr, "attributeBuffer");
			MutableAttributesAnalyzer.NativeFieldInfoPtr_IAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributesAnalyzer>.NativeClassPtr, "IAttributeType");
			MutableAttributesAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesAnalyzer>.NativeClassPtr, 100663451);
			MutableAttributesAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributesAnalyzer>.NativeClassPtr, 100663452);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000903C File Offset: 0x0000723C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216925, XrefRangeEnd = 1216945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributesAnalyzer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributesAnalyzer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributesAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00009078 File Offset: 0x00007278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216945, XrefRangeEnd = 1217018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Analyze(DwdModelAnalyzer analyzer, MorePeekableStream tokens, Type targetType, out Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(analyzer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MutableAttributesAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002BE2 File Offset: 0x00000DE2
		public MutableAttributesAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00009110 File Offset: 0x00007310
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002BEB File Offset: 0x00000DEB
		public unsafe static List<IAttribute> attributeBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MutableAttributesAnalyzer.NativeFieldInfoPtr_attributeBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MutableAttributesAnalyzer.NativeFieldInfoPtr_attributeBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00009138 File Offset: 0x00007338
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002BFD File Offset: 0x00000DFD
		public unsafe Type IAttributeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributesAnalyzer.NativeFieldInfoPtr_IAttributeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributesAnalyzer.NativeFieldInfoPtr_IAttributeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_attributeBuffer;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_IAttributeType;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0;
	}
}
