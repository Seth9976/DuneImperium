using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000121 RID: 289
	public sealed class ByReference<T> : ValueType
	{
		// Token: 0x06001374 RID: 4980 RVA: 0x000845CC File Offset: 0x000827CC
		// Note: this type is marked as 'beforefieldinit'.
		static ByReference()
		{
			Il2CppClassPointerStore<ByReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ByReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByReference<T>>.NativeClassPtr);
			ByReference<T>.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByReference<T>>.NativeClassPtr, "_value");
			ByReference<T>.NativeMethodInfoPtr__ctor_Public_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByReference<T>>.NativeClassPtr, 100666769);
			ByReference<T>.NativeMethodInfoPtr_get_Value_Public_get_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByReference<T>>.NativeClassPtr, 100666770);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00084674 File Offset: 0x00082874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297223, RefRangeEnd = 297224, XrefRangeStart = 297223, XrefRangeEnd = 297224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByReference(ref T value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByReference<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ByReference<T>.NativeMethodInfoPtr__ctor_Public_Void_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x000846DC File Offset: 0x000828DC
		public unsafe ref T Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByReference<T>.NativeMethodInfoPtr_get_Value_Public_get_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x000062F5 File Offset: 0x000044F5
		public ByReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x000062FE File Offset: 0x000044FE
		public ByReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByReference<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00084714 File Offset: 0x00082914
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x00006310 File Offset: 0x00004510
		public unsafe IntPtr _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByReference<T>.NativeFieldInfoPtr__value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByReference<T>.NativeFieldInfoPtr__value)) = value;
			}
		}

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_T_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_byref_T_0;
	}
}
