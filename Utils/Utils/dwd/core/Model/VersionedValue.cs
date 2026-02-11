using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.Model
{
	// Token: 0x02000026 RID: 38
	public class VersionedValue<T> : Object where T : new()
	{
		// Token: 0x06000184 RID: 388 RVA: 0x0000A630 File Offset: 0x00008830
		// Note: this type is marked as 'beforefieldinit'.
		static VersionedValue()
		{
			Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Utils.dll", "dwd.core.Model", "VersionedValue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr);
			VersionedValue<T>.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr, "<Version>k__BackingField");
			VersionedValue<T>.NativeFieldInfoPtr_internalValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr, "internalValue");
			VersionedValue<T>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr, "comparer");
			VersionedValue<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr, 100663535);
			VersionedValue<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr, 100663536);
			VersionedValue<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr, 100663537);
			VersionedValue<T>.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr, 100663538);
			VersionedValue<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr, 100663539);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000A73C File Offset: 0x0000893C
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000A778 File Offset: 0x00008978
		public unsafe T Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedValue<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1181245, RefRangeEnd = 1181247, XrefRangeStart = 1181242, XrefRangeEnd = 1181245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedValue<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000A7F0 File Offset: 0x000089F0
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000A82C File Offset: 0x00008A2C
		public unsafe virtual ulong Version
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedValue<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedValue<T>.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000A86C File Offset: 0x00008A6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067278, RefRangeEnd = 1067280, XrefRangeStart = 1067278, XrefRangeEnd = 1067280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedValue<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedValue<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000026DF File Offset: 0x000008DF
		public VersionedValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000026E8 File Offset: 0x000008E8
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedValue<T>.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedValue<T>.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0000A8F8 File Offset: 0x00008AF8
		public unsafe T internalValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedValue<T>.NativeFieldInfoPtr_internalValue);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedValue<T>.NativeFieldInfoPtr_internalValue);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002703 File Offset: 0x00000903
		public unsafe static EqualityComparer<T> comparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VersionedValue<T>.NativeFieldInfoPtr_comparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionedValue<T>.NativeFieldInfoPtr_comparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_internalValue;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_T_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
