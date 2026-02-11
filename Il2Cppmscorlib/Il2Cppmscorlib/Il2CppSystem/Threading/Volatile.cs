using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001C5 RID: 453
	public static class Volatile : Object
	{
		// Token: 0x06001DC6 RID: 7622 RVA: 0x000AD830 File Offset: 0x000ABA30
		// Note: this type is marked as 'beforefieldinit'.
		static Volatile()
		{
			Il2CppClassPointerStore<Volatile>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Volatile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volatile>.NativeClassPtr);
			Volatile.NativeMethodInfoPtr_Read_Public_Static_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668349);
			Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668350);
			Volatile.NativeMethodInfoPtr_Read_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668351);
			Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668352);
			Volatile.NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668353);
			Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668354);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x000AD8D8 File Offset: 0x000ABAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357766, XrefRangeEnd = 1357767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Read(ref bool location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volatile.NativeMethodInfoPtr_Read_Public_Static_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x000AD918 File Offset: 0x000ABB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357767, XrefRangeEnd = 1357768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write(ref bool location, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x000AD958 File Offset: 0x000ABB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357768, XrefRangeEnd = 1357769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Read(ref int location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volatile.NativeMethodInfoPtr_Read_Public_Static_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x000AD998 File Offset: 0x000ABB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357769, XrefRangeEnd = 1357770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write(ref int location, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x000AD9D8 File Offset: 0x000ABBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357770, XrefRangeEnd = 1357771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Read<T>(ref T location) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(location);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Volatile.MethodInfoStoreGeneric_Read_Public_Static_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				location = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x000ADA30 File Offset: 0x000ABC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357771, XrefRangeEnd = 1357773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write<T>(ref T location, T value) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Volatile.MethodInfoStoreGeneric_Write_Public_Static_Void_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			location = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00009C62 File Offset: 0x00007E62
		public Volatile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Boolean_byref_Boolean_0;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_byref_Boolean_Boolean_0;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Int32_byref_Int32_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_byref_Int32_Int32_0;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0;

		// Token: 0x0200061B RID: 1563
		[StructLayout(2)]
		public struct VolatileBoolean
		{
			// Token: 0x060058D4 RID: 22740 RVA: 0x0001FAC3 File Offset: 0x0001DCC3
			// Note: this type is marked as 'beforefieldinit'.
			static VolatileBoolean()
			{
				Il2CppClassPointerStore<Volatile.VolatileBoolean>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Volatile>.NativeClassPtr, "VolatileBoolean");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volatile.VolatileBoolean>.NativeClassPtr);
				Volatile.VolatileBoolean.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volatile.VolatileBoolean>.NativeClassPtr, "Value");
			}

			// Token: 0x060058D5 RID: 22741 RVA: 0x0001FAF7 File Offset: 0x0001DCF7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Volatile.VolatileBoolean>.NativeClassPtr, ref this));
			}

			// Token: 0x040048FA RID: 18682
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x040048FB RID: 18683
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool Value;
		}

		// Token: 0x0200061C RID: 1564
		[StructLayout(2)]
		public struct VolatileInt32
		{
			// Token: 0x060058D6 RID: 22742 RVA: 0x0001FB09 File Offset: 0x0001DD09
			// Note: this type is marked as 'beforefieldinit'.
			static VolatileInt32()
			{
				Il2CppClassPointerStore<Volatile.VolatileInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Volatile>.NativeClassPtr, "VolatileInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volatile.VolatileInt32>.NativeClassPtr);
				Volatile.VolatileInt32.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volatile.VolatileInt32>.NativeClassPtr, "Value");
			}

			// Token: 0x060058D7 RID: 22743 RVA: 0x0001FB3D File Offset: 0x0001DD3D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Volatile.VolatileInt32>.NativeClassPtr, ref this));
			}

			// Token: 0x040048FC RID: 18684
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x040048FD RID: 18685
			[FieldOffset(0)]
			public int Value;
		}

		// Token: 0x0200061D RID: 1565
		public sealed class VolatileObject : ValueType
		{
			// Token: 0x060058D8 RID: 22744 RVA: 0x0001FB4F File Offset: 0x0001DD4F
			// Note: this type is marked as 'beforefieldinit'.
			static VolatileObject()
			{
				Il2CppClassPointerStore<Volatile.VolatileObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Volatile>.NativeClassPtr, "VolatileObject");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volatile.VolatileObject>.NativeClassPtr);
				Volatile.VolatileObject.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volatile.VolatileObject>.NativeClassPtr, "Value");
			}

			// Token: 0x060058D9 RID: 22745 RVA: 0x0001FB83 File Offset: 0x0001DD83
			public VolatileObject(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060058DA RID: 22746 RVA: 0x0001FB8C File Offset: 0x0001DD8C
			public VolatileObject()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Volatile.VolatileObject>.NativeClassPtr))
			{
			}

			// Token: 0x170016A3 RID: 5795
			// (get) Token: 0x060058DB RID: 22747 RVA: 0x00197F8C File Offset: 0x0019618C
			// (set) Token: 0x060058DC RID: 22748 RVA: 0x0001FB9E File Offset: 0x0001DD9E
			public unsafe Object Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volatile.VolatileObject.NativeFieldInfoPtr_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Volatile.VolatileObject.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048FE RID: 18686
			private static readonly IntPtr NativeFieldInfoPtr_Value;
		}

		// Token: 0x0200061E RID: 1566
		private sealed class MethodInfoStoreGeneric_Read_Public_Static_T_byref_T_0<T>
		{
			// Token: 0x040048FF RID: 18687
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Volatile.NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0, Il2CppClassPointerStore<Volatile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200061F RID: 1567
		private sealed class MethodInfoStoreGeneric_Write_Public_Static_Void_byref_T_T_0<T>
		{
			// Token: 0x04004900 RID: 18688
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Volatile.NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0, Il2CppClassPointerStore<Volatile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
