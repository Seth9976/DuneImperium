using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Buffers
{
	// Token: 0x02000511 RID: 1297
	public class ArrayPool<T> : Object
	{
		// Token: 0x06004F74 RID: 20340 RVA: 0x00171F9C File Offset: 0x0017019C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayPool()
		{
			Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "ArrayPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr);
			ArrayPool<T>.NativeFieldInfoPtr__Shared_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, "<Shared>k__BackingField");
			ArrayPool<T>.NativeMethodInfoPtr_get_Shared_Public_Static_get_ArrayPool_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, 100675283);
			ArrayPool<T>.NativeMethodInfoPtr_Rent_Public_Abstract_Virtual_New_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, 100675284);
			ArrayPool<T>.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Void_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, 100675285);
			ArrayPool<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr, 100675286);
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06004F75 RID: 20341 RVA: 0x0017206C File Offset: 0x0017026C
		public unsafe static ArrayPool<T> Shared
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426495, XrefRangeEnd = 1426499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPool<T>.NativeMethodInfoPtr_get_Shared_Public_Static_get_ArrayPool_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayPool<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x001720A0 File Offset: 0x001702A0
		[CallerCount(0)]
		public unsafe virtual Il2CppArrayBase<T> Rent(int minimumLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimumLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayPool<T>.NativeMethodInfoPtr_Rent_Public_Abstract_Virtual_New_Il2CppArrayBase_1_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x001720F0 File Offset: 0x001702F0
		[CallerCount(0)]
		public unsafe virtual void Return(Il2CppArrayBase<T> array, bool clearArray = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearArray;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayPool<T>.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Void_Il2CppArrayBase_1_T_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x0017214C File Offset: 0x0017034C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayPool<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x0001C83B File Offset: 0x0001AA3B
		public ArrayPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06004F7A RID: 20346 RVA: 0x00172188 File Offset: 0x00170388
		// (set) Token: 0x06004F7B RID: 20347 RVA: 0x0001C844 File Offset: 0x0001AA44
		public unsafe static ArrayPool<T> _Shared_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArrayPool<T>.NativeFieldInfoPtr__Shared_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayPool<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrayPool<T>.NativeFieldInfoPtr__Shared_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040CB RID: 16587
		private static readonly IntPtr NativeFieldInfoPtr__Shared_k__BackingField;

		// Token: 0x040040CC RID: 16588
		private static readonly IntPtr NativeMethodInfoPtr_get_Shared_Public_Static_get_ArrayPool_1_T_0;

		// Token: 0x040040CD RID: 16589
		private static readonly IntPtr NativeMethodInfoPtr_Rent_Public_Abstract_Virtual_New_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040040CE RID: 16590
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Void_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x040040CF RID: 16591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
