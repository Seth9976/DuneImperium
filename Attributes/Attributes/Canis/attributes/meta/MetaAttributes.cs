using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.attributes.meta
{
	// Token: 0x02000026 RID: 38
	public class MetaAttributes : Object
	{
		// Token: 0x0600027D RID: 637 RVA: 0x0000C680 File Offset: 0x0000A880
		// Note: this type is marked as 'beforefieldinit'.
		static MetaAttributes()
		{
			Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes.meta", "MetaAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr);
			MetaAttributes.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, "data");
			MetaAttributes.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, 100663602);
			MetaAttributes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, 100663603);
			MetaAttributes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, 100663604);
			MetaAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, 100663605);
			MetaAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, 100663606);
			MetaAttributes.NativeMethodInfoPtr_GetAttribute_Public_IAttribute_1_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, 100663607);
			MetaAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, 100663608);
			MetaAttributes.NativeMethodInfoPtr_AddAttribute_Public_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, 100663609);
			MetaAttributes.NativeMethodInfoPtr_ReplaceAttribute_Public_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr, 100663610);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000C778 File Offset: 0x0000A978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1219252, RefRangeEnd = 1219253, XrefRangeStart = 1219220, XrefRangeEnd = 1219252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaAttributes(IEnumerable<IAttribute> attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaAttributes.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1219254, RefRangeEnd = 1219260, XrefRangeStart = 1219253, XrefRangeEnd = 1219254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaAttributes([Optional] Il2CppReferenceArray<IAttribute> attrs)
		{
			if (attrs == null)
			{
				attrs = new Il2CppReferenceArray<IAttribute>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaAttributes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000C81C File Offset: 0x0000AA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219260, XrefRangeEnd = 1219269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<IAttribute> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaAttributes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000C85C File Offset: 0x0000AA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219269, XrefRangeEnd = 1219278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000C89C File Offset: 0x0000AA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219278, XrefRangeEnd = 1219282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219282, XrefRangeEnd = 1219292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAttribute<V> GetAttribute<V>(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaAttributes.MethodInfoStoreGeneric_GetAttribute_Public_IAttribute_1_V_Int32_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000C934 File Offset: 0x0000AB34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1219303, RefRangeEnd = 1219304, XrefRangeStart = 1219292, XrefRangeEnd = 1219303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaAttributes.MethodInfoStoreGeneric_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000C984 File Offset: 0x0000AB84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1219310, RefRangeEnd = 1219311, XrefRangeStart = 1219304, XrefRangeEnd = 1219310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttribute(IAttribute newAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newAttribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaAttributes.NativeMethodInfoPtr_AddAttribute_Public_Void_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000C9C8 File Offset: 0x0000ABC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1219318, RefRangeEnd = 1219320, XrefRangeStart = 1219311, XrefRangeEnd = 1219318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceAttribute(IAttribute newAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newAttribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaAttributes.NativeMethodInfoPtr_ReplaceAttribute_Public_Void_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002EC0 File Offset: 0x000010C0
		public MetaAttributes(params IAttribute[] attrs)
			: this(new Il2CppReferenceArray<IAttribute>(attrs))
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002ECE File Offset: 0x000010CE
		public MetaAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00002ED7 File Offset: 0x000010D7
		public unsafe Dictionary<int, IAttribute> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaAttributes.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaAttributes.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAttribute_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IAttribute_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_IAttribute_1_V_Int32_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Void_IAttribute_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceAttribute_Public_Void_IAttribute_0;

		// Token: 0x0200005A RID: 90
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_IAttribute_1_V_Int32_0<V>
		{
			// Token: 0x0400024A RID: 586
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MetaAttributes.NativeMethodInfoPtr_GetAttribute_Public_IAttribute_1_V_Int32_0, Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005B RID: 91
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x0400024B RID: 587
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MetaAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<MetaAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}
	}
}
