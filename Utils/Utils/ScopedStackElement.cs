using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Utils
{
	// Token: 0x02000036 RID: 54
	public class ScopedStackElement<T> : Object
	{
		// Token: 0x06000238 RID: 568 RVA: 0x0000DB4C File Offset: 0x0000BD4C
		// Note: this type is marked as 'beforefieldinit'.
		static ScopedStackElement()
		{
			Il2CppClassPointerStore<ScopedStackElement<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "ScopedStackElement`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopedStackElement<T>>.NativeClassPtr);
			ScopedStackElement<T>.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedStackElement<T>>.NativeClassPtr, "_value");
			ScopedStackElement<T>.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedStackElement<T>>.NativeClassPtr, "_stack");
			ScopedStackElement<T>.NativeMethodInfoPtr__ctor_Public_Void_T_ScopedStack_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedStackElement<T>>.NativeClassPtr, 100663843);
			ScopedStackElement<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedStackElement<T>>.NativeClassPtr, 100663844);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000DC08 File Offset: 0x0000BE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183789, XrefRangeEnd = 1183796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScopedStackElement(T value, ScopedStack<T> scopedStack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopedStackElement<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scopedStack);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ScopedStackElement<T>.NativeMethodInfoPtr__ctor_Public_Void_T_ScopedStack_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000DC9C File Offset: 0x0000BE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183796, XrefRangeEnd = 1183813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedStackElement<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002A04 File Offset: 0x00000C04
		public ScopedStackElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		public unsafe T _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedStackElement<T>.NativeFieldInfoPtr__value);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedStackElement<T>.NativeFieldInfoPtr__value);
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002A0D File Offset: 0x00000C0D
		public unsafe ScopedStack<T> _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedStackElement<T>.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScopedStack<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedStackElement<T>.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_ScopedStack_1_T_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
