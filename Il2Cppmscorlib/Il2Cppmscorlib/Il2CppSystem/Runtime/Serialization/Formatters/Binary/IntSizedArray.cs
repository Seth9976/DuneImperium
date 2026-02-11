using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000371 RID: 881
	[Serializable]
	public sealed class IntSizedArray : Object
	{
		// Token: 0x060036EB RID: 14059 RVA: 0x0010DDD4 File Offset: 0x0010BFD4
		// Note: this type is marked as 'beforefieldinit'.
		static IntSizedArray()
		{
			Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "IntSizedArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr);
			IntSizedArray.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, "objects");
			IntSizedArray.NativeFieldInfoPtr_negObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, "negObjects");
			IntSizedArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100671573);
			IntSizedArray.NativeMethodInfoPtr__ctor_Private_Void_IntSizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100671574);
			IntSizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100671575);
			IntSizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100671576);
			IntSizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100671577);
			IntSizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100671578);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x0010DEA4 File Offset: 0x0010C0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391061, XrefRangeEnd = 1391069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntSizedArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x0010DEE0 File Offset: 0x0010C0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391069, XrefRangeEnd = 1391086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntSizedArray(IntSizedArray sizedArray)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sizedArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr__ctor_Private_Void_IntSizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x0010DF2C File Offset: 0x0010C12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391086, XrefRangeEnd = 1391105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000CE0 RID: 3296
		public unsafe int this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391105, XrefRangeEnd = 1391106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x0010E004 File Offset: 0x0010C204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391123, RefRangeEnd = 1391124, XrefRangeStart = 1391106, XrefRangeEnd = 1391123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x00013F29 File Offset: 0x00012129
		public IntSizedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x0010E044 File Offset: 0x0010C244
		// (set) Token: 0x060036F4 RID: 14068 RVA: 0x00013F32 File Offset: 0x00012132
		public unsafe Il2CppStructArray<int> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060036F5 RID: 14069 RVA: 0x0010E074 File Offset: 0x0010C274
		// (set) Token: 0x060036F6 RID: 14070 RVA: 0x00013F51 File Offset: 0x00012151
		public unsafe Il2CppStructArray<int> negObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_negObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_negObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002CA9 RID: 11433
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x04002CAA RID: 11434
		private static readonly IntPtr NativeFieldInfoPtr_negObjects;

		// Token: 0x04002CAB RID: 11435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CAC RID: 11436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IntSizedArray_0;

		// Token: 0x04002CAD RID: 11437
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04002CAE RID: 11438
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Int32_Int32_0;

		// Token: 0x04002CAF RID: 11439
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Int32_0;

		// Token: 0x04002CB0 RID: 11440
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0;
	}
}
