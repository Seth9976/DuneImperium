using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.conditions
{
	// Token: 0x020000AE RID: 174
	public class Condition<T> : MonoBehaviour
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x000208D4 File Offset: 0x0001EAD4
		// Note: this type is marked as 'beforefieldinit'.
		static Condition()
		{
			Il2CppClassPointerStore<Condition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.conditions", "Condition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Condition<T>>.NativeClassPtr);
			Condition<T>.NativeMethodInfoPtr_Matches_Public_Abstract_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition<T>>.NativeClassPtr, 100664264);
			Condition<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition<T>>.NativeClassPtr, 100664265);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00020968 File Offset: 0x0001EB68
		[CallerCount(0)]
		public unsafe virtual bool Matches(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Condition<T>.NativeMethodInfoPtr_Matches_Public_Abstract_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000209F8 File Offset: 0x0001EBF8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Condition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Condition<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Condition<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00006248 File Offset: 0x00004448
		public Condition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Abstract_Virtual_New_Boolean_T_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
