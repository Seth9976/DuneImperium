using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000052 RID: 82
	public sealed class ListChangedEventArgs<T> : EventArgs
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x000235D8 File Offset: 0x000217D8
		// Note: this type is marked as 'beforefieldinit'.
		static ListChangedEventArgs()
		{
			Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ListChangedEventArgs`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr);
			ListChangedEventArgs<T>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr, "index");
			ListChangedEventArgs<T>.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr, "item");
			ListChangedEventArgs<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr, 100664055);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00023680 File Offset: 0x00021880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 960404, RefRangeEnd = 960406, XrefRangeStart = 960399, XrefRangeEnd = 960404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListChangedEventArgs(int index, T item)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListChangedEventArgs<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00004614 File Offset: 0x00002814
		public ListChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00023710 File Offset: 0x00021910
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x0000461D File Offset: 0x0000281D
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs<T>.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs<T>.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00023738 File Offset: 0x00021938
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00023760 File Offset: 0x00021960
		public unsafe T item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs<T>.NativeFieldInfoPtr_item);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs<T>.NativeFieldInfoPtr_item);
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

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_T_0;
	}
}
