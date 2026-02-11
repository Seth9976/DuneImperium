using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000131 RID: 305
	public sealed class CastHelper<T> : ValueType
	{
		// Token: 0x060017C1 RID: 6081 RVA: 0x000704B0 File Offset: 0x0006E6B0
		// Note: this type is marked as 'beforefieldinit'.
		static CastHelper()
		{
			Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CastHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr);
			CastHelper<T>.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr, "t");
			CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr, "onePointerFurtherThanT");
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000096F3 File Offset: 0x000078F3
		public CastHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000096FC File Offset: 0x000078FC
		public CastHelper()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastHelper<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00070544 File Offset: 0x0006E744
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0007056C File Offset: 0x0006E76C
		public unsafe T t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_t);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_t);
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00070614 File Offset: 0x0006E814
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0000970E File Offset: 0x0000790E
		public unsafe IntPtr onePointerFurtherThanT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CastHelper<T>.NativeFieldInfoPtr_onePointerFurtherThanT)) = value;
			}
		}

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeFieldInfoPtr_t;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeFieldInfoPtr_onePointerFurtherThanT;
	}
}
