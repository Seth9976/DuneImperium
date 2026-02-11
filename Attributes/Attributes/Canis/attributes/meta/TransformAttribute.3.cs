using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes.meta
{
	// Token: 0x02000029 RID: 41
	public class TransformAttribute : ReadOnlyAttribute
	{
		// Token: 0x060002BF RID: 703 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
		// Note: this type is marked as 'beforefieldinit'.
		static TransformAttribute()
		{
			Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes.meta", "TransformAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr);
			TransformAttribute.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, "_source");
			TransformAttribute.NativeFieldInfoPtr__definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, "_definition");
			TransformAttribute.NativeFieldInfoPtr__transformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, "_transformation");
			TransformAttribute.NativeFieldInfoPtr__cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, "_cachedVersion");
			TransformAttribute.NativeFieldInfoPtr__cachedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, "_cachedValue");
			TransformAttribute.NativeFieldInfoPtr__cachedModValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, "_cachedModValue");
			TransformAttribute.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_IAttributeDefinition_Func_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, 100663629);
			TransformAttribute.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, 100663630);
			TransformAttribute.NativeMethodInfoPtr_get_Name_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, 100663631);
			TransformAttribute.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, 100663632);
			TransformAttribute.NativeMethodInfoPtr_get_objectValue_Protected_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, 100663633);
			TransformAttribute.NativeMethodInfoPtr_get_objectModValue_Protected_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr, 100663634);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000D914 File Offset: 0x0000BB14
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformAttribute(IAttribute source, IAttributeDefinition definition, Func<Object, Object> transformation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_IAttributeDefinition_Func_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000D984 File Offset: 0x0000BB84
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219500, XrefRangeEnd = 1219504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformAttribute.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		public unsafe override int Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219504, XrefRangeEnd = 1219508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformAttribute.NativeMethodInfoPtr_get_Name_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000DA14 File Offset: 0x0000BC14
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219508, XrefRangeEnd = 1219512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformAttribute.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000DA60 File Offset: 0x0000BC60
		public unsafe override Object objectValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219512, XrefRangeEnd = 1219519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformAttribute.NativeMethodInfoPtr_get_objectValue_Protected_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		public unsafe override Object objectModValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219519, XrefRangeEnd = 1219526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformAttribute.NativeMethodInfoPtr_get_objectModValue_Protected_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003055 File Offset: 0x00001255
		public TransformAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x0000305E File Offset: 0x0000125E
		public unsafe IAttribute _source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000DB28 File Offset: 0x0000BD28
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0000307D File Offset: 0x0000127D
		public unsafe IAttributeDefinition _definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttributeDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000DB58 File Offset: 0x0000BD58
		// (set) Token: 0x060002CC RID: 716 RVA: 0x0000309C File Offset: 0x0000129C
		public unsafe Func<Object, Object> _transformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__transformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__transformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000DB88 File Offset: 0x0000BD88
		// (set) Token: 0x060002CE RID: 718 RVA: 0x000030BB File Offset: 0x000012BB
		public unsafe ulong _cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__cachedVersion)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x000030D6 File Offset: 0x000012D6
		public unsafe Object _cachedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__cachedValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__cachedValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x000030F5 File Offset: 0x000012F5
		public unsafe Object _cachedModValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__cachedModValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute.NativeFieldInfoPtr__cachedModValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr__definition;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr__transformation;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr__cachedVersion;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr__cachedValue;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr__cachedModValue;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_IAttributeDefinition_Func_2_Object_Object_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_Int32_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_objectValue_Protected_Virtual_get_Object_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_get_objectModValue_Protected_Virtual_get_Object_0;
	}
}
