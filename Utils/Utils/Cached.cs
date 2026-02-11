using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Utils
{
	// Token: 0x0200002D RID: 45
	public sealed class Cached<T> : Object
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x0000B1D0 File Offset: 0x000093D0
		// Note: this type is marked as 'beforefieldinit'.
		static Cached()
		{
			Il2CppClassPointerStore<Cached<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "Cached`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cached<T>>.NativeClassPtr);
			Cached<T>.NativeFieldInfoPtr__generator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cached<T>>.NativeClassPtr, "_generator");
			Cached<T>.NativeFieldInfoPtr__cached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cached<T>>.NativeClassPtr, "_cached");
			Cached<T>.NativeFieldInfoPtr__cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cached<T>>.NativeClassPtr, "_cache");
			Cached<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cached<T>>.NativeClassPtr, 100663556);
			Cached<T>.NativeMethodInfoPtr_Get_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cached<T>>.NativeClassPtr, 100663557);
			Cached<T>.NativeMethodInfoPtr_Invalidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cached<T>>.NativeClassPtr, 100663558);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000B2B4 File Offset: 0x000094B4
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cached(Func<T> generator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cached<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cached<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000B300 File Offset: 0x00009500
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1181285, RefRangeEnd = 1181291, XrefRangeStart = 1181284, XrefRangeEnd = 1181285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cached<T>.NativeMethodInfoPtr_Get_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000B33C File Offset: 0x0000953C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1181291, RefRangeEnd = 1181293, XrefRangeStart = 1181291, XrefRangeEnd = 1181291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invalidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cached<T>.NativeMethodInfoPtr_Invalidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002879 File Offset: 0x00000A79
		public Cached(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000B370 File Offset: 0x00009570
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002882 File Offset: 0x00000A82
		public unsafe Func<T> _generator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cached<T>.NativeFieldInfoPtr__generator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cached<T>.NativeFieldInfoPtr__generator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000B3A0 File Offset: 0x000095A0
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x000028A1 File Offset: 0x00000AA1
		public unsafe bool _cached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cached<T>.NativeFieldInfoPtr__cached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cached<T>.NativeFieldInfoPtr__cached)) = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000B3C8 File Offset: 0x000095C8
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0000B3F0 File Offset: 0x000095F0
		public unsafe T _cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cached<T>.NativeFieldInfoPtr__cache);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cached<T>.NativeFieldInfoPtr__cache);
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

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr__generator;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr__cached;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr__cache;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_Invalidate_Public_Void_0;
	}
}
