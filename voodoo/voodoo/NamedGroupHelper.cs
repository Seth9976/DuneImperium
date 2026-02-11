using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;

namespace voodoo
{
	// Token: 0x02000018 RID: 24
	public class NamedGroupHelper<T> : MonoBehaviour
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x0000B2C4 File Offset: 0x000094C4
		// Note: this type is marked as 'beforefieldinit'.
		static NamedGroupHelper()
		{
			Il2CppClassPointerStore<NamedGroupHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo", "NamedGroupHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamedGroupHelper<T>>.NativeClassPtr);
			NamedGroupHelper<T>.NativeFieldInfoPtr_namedGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedGroupHelper<T>>.NativeClassPtr, "namedGroups");
			NamedGroupHelper<T>.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedGroupHelper<T>>.NativeClassPtr, 100663381);
			NamedGroupHelper<T>.NativeMethodInfoPtr_initializeData_Protected_Abstract_Virtual_New_Il2CppReferenceArray_1_NamedGroup_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedGroupHelper<T>>.NativeClassPtr, 100663382);
			NamedGroupHelper<T>.NativeMethodInfoPtr_GetGroup_Public_NamedGroup_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedGroupHelper<T>>.NativeClassPtr, 100663383);
			NamedGroupHelper<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedGroupHelper<T>>.NativeClassPtr, 100663384);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000B394 File Offset: 0x00009594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106888, XrefRangeEnd = 1106890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedGroupHelper<T>.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000B3C8 File Offset: 0x000095C8
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<NamedGroup<T>> initializeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamedGroupHelper<T>.NativeMethodInfoPtr_initializeData_Protected_Abstract_Virtual_New_Il2CppReferenceArray_1_NamedGroup_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NamedGroup<T>>>(intPtr3) : null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000B414 File Offset: 0x00009614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106890, XrefRangeEnd = 1106892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamedGroup<T> GetGroup(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedGroupHelper<T>.NativeMethodInfoPtr_GetGroup_Public_NamedGroup_1_T_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamedGroup<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000B464 File Offset: 0x00009664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1106905, RefRangeEnd = 1106906, XrefRangeStart = 1106892, XrefRangeEnd = 1106905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamedGroupHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamedGroupHelper<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedGroupHelper<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000026BA File Offset: 0x000008BA
		public NamedGroupHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000B4A0 File Offset: 0x000096A0
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000026C3 File Offset: 0x000008C3
		public unsafe LocalDataManager<string, NamedGroup<T>> namedGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedGroupHelper<T>.NativeFieldInfoPtr_namedGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataManager<string, NamedGroup<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedGroupHelper<T>.NativeFieldInfoPtr_namedGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_namedGroups;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_initializeData_Protected_Abstract_Virtual_New_Il2CppReferenceArray_1_NamedGroup_1_T_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_GetGroup_Public_NamedGroup_1_T_String_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
