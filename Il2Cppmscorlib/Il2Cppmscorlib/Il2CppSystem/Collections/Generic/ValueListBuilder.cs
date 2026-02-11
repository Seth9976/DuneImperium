using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004F0 RID: 1264
	[DefaultMember("Item")]
	public sealed class ValueListBuilder<T> : ValueType
	{
		// Token: 0x06004E12 RID: 19986 RVA: 0x0016AAD4 File Offset: 0x00168CD4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueListBuilder()
		{
			Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ValueListBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr);
			ValueListBuilder<T>.NativeFieldInfoPtr__span = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, "_span");
			ValueListBuilder<T>.NativeFieldInfoPtr__arrayFromPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, "_arrayFromPool");
			ValueListBuilder<T>.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, "_pos");
			ValueListBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100675049);
			ValueListBuilder<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100675050);
			ValueListBuilder<T>.NativeMethodInfoPtr_Append_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100675051);
			ValueListBuilder<T>.NativeMethodInfoPtr_AsSpan_Public_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100675052);
			ValueListBuilder<T>.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100675053);
			ValueListBuilder<T>.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100675054);
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x0016ABF4 File Offset: 0x00168DF4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 467556, RefRangeEnd = 467567, XrefRangeStart = 467556, XrefRangeEnd = 467567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueListBuilder(Span<T> initialSpan)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(initialSpan));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Span_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x0016AC4C File Offset: 0x00168E4C
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x0016AC90 File Offset: 0x00168E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425201, XrefRangeEnd = 1425204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_Append_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x0016AD10 File Offset: 0x00168F10
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 467578, RefRangeEnd = 467584, XrefRangeStart = 467578, XrefRangeEnd = 467584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan<T> AsSpan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_AsSpan_Public_ReadOnlySpan_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ReadOnlySpan<T>(intPtr);
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x0016AD4C File Offset: 0x00168F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x0016AD84 File Offset: 0x00168F84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 467606, RefRangeEnd = 467611, XrefRangeStart = 467606, XrefRangeEnd = 467611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x0001C2BE File Offset: 0x0001A4BE
		public ValueListBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x0001C2C7 File Offset: 0x0001A4C7
		public ValueListBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06004E1B RID: 19995 RVA: 0x0016ADBC File Offset: 0x00168FBC
		// (set) Token: 0x06004E1C RID: 19996 RVA: 0x0001C2D9 File Offset: 0x0001A4D9
		public Span<T> _span
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__span);
				return new Span<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Span<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__span), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Span<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06004E1D RID: 19997 RVA: 0x0016ADEC File Offset: 0x00168FEC
		// (set) Token: 0x06004E1E RID: 19998 RVA: 0x0001C307 File Offset: 0x0001A507
		public unsafe Il2CppArrayBase<T> _arrayFromPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__arrayFromPool);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__arrayFromPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06004E1F RID: 19999 RVA: 0x0016AE14 File Offset: 0x00169014
		// (set) Token: 0x06004E20 RID: 20000 RVA: 0x0001C326 File Offset: 0x0001A526
		public unsafe int _pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__pos)) = value;
			}
		}

		// Token: 0x04003FD7 RID: 16343
		private static readonly IntPtr NativeFieldInfoPtr__span;

		// Token: 0x04003FD8 RID: 16344
		private static readonly IntPtr NativeFieldInfoPtr__arrayFromPool;

		// Token: 0x04003FD9 RID: 16345
		private static readonly IntPtr NativeFieldInfoPtr__pos;

		// Token: 0x04003FDA RID: 16346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Span_1_T_0;

		// Token: 0x04003FDB RID: 16347
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04003FDC RID: 16348
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_T_0;

		// Token: 0x04003FDD RID: 16349
		private static readonly IntPtr NativeMethodInfoPtr_AsSpan_Public_ReadOnlySpan_1_T_0;

		// Token: 0x04003FDE RID: 16350
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04003FDF RID: 16351
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;
	}
}
