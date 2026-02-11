using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009C RID: 156
	public class ReflectionAttributeProvider : Object
	{
		// Token: 0x06000D6D RID: 3437 RVA: 0x0004FDB8 File Offset: 0x0004DFB8
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionAttributeProvider()
		{
			Il2CppClassPointerStore<ReflectionAttributeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "ReflectionAttributeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionAttributeProvider>.NativeClassPtr);
			ReflectionAttributeProvider.NativeFieldInfoPtr__attributeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionAttributeProvider>.NativeClassPtr, "_attributeProvider");
			ReflectionAttributeProvider.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionAttributeProvider>.NativeClassPtr, 100665742);
			ReflectionAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IList_1_Attribute_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionAttributeProvider>.NativeClassPtr, 100665743);
			ReflectionAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IList_1_Attribute_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionAttributeProvider>.NativeClassPtr, 100665744);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0004FE38 File Offset: 0x0004E038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 753736, RefRangeEnd = 753738, XrefRangeStart = 753731, XrefRangeEnd = 753736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionAttributeProvider(Object attributeProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionAttributeProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionAttributeProvider.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0004FE84 File Offset: 0x0004E084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753738, XrefRangeEnd = 753742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<Attribute> GetAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IList_1_Attribute_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0004FED0 File Offset: 0x0004E0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753742, XrefRangeEnd = 753746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<Attribute> GetAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IList_1_Attribute_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x000065F4 File Offset: 0x000047F4
		public ReflectionAttributeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0004FF30 File Offset: 0x0004E130
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x000065FD File Offset: 0x000047FD
		public unsafe Object _attributeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionAttributeProvider.NativeFieldInfoPtr__attributeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionAttributeProvider.NativeFieldInfoPtr__attributeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr__attributeProvider;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IList_1_Attribute_Boolean_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IList_1_Attribute_Type_Boolean_0;
	}
}
